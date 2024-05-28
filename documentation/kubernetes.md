## Before you begin 
A compatible Linux host. The Kubernetes project provides generic instructions for Linux distributions based on Debian and Red Hat, and those distributions without a package manager.
- 2 GB or more of RAM per machine (any less will leave little room for your apps).
- 2 CPUs or more.
- Full network connectivity between all machines in the cluster (public or private network is fine).
- Unique hostname, MAC address, and product_uuid for every node. 
- Certain ports are open on your machines.
### Swap configuration 
The default behavior of a kubelet was to fail to start if swap memory was detected on a node. Swap has been supported since v1.22. And since v1.28, Swap is supported for cgroup v2 only; the NodeSwap feature gate of the kubelet is beta but disabled by default.
You MUST disable `swap` if the kubelet is not properly configured to use `swap`. 

Write the following command to swap off.
```sudo swapoff -a``` 

It will disable swapping temporarily. To make this change persistent across reboots, make sure swap is disabled in config files like `/etc/fstab`, `systemd.swap`, depending how it was configured on your system.

### Verify the MAC address and product_uuid are unique for every node 
You can get the MAC address of the network interfaces using the command 
```ip link``` 
or 
```ifconfig -a```
The product_uuid can be checked by using the command 
```
sudo cat /sys/class/dmi/id/product_uuid
```
It is very likely that hardware devices will have unique addresses, although some virtual machines may have identical values. Kubernetes uses these values to uniquely identify the nodes in the cluster. If these values are not unique to each node, the installation process may fail.

### Check network adapters 
If you have more than one network adapter, and your Kubernetes components are not reachable on the default route, we recommend you add IP route(s) so Kubernetes cluster addresses go via the appropriate adapter.

### Check required ports 
These required ports need to be open in order for Kubernetes components to communicate with each other. You can use tools like netcat to check if a port is open. For example:

```
nc 127.0.0.1 6443 -v
```

The pod network plugin you use may also require certain ports to be open. Since this differs with each pod network plugin, please see the documentation for the plugins about what port(s) those need.

### Install Vim
```
sudo apt-get install vim
```

## Installing a container runtime
To run containers in Pods, Kubernetes uses a container runtime. By default, Kubernetes uses the Container Runtime Interface (CRI) to interface with your chosen container runtime. If you don't specify a runtime, kubeadm automatically tries to detect an installed container runtime by scanning through a list of known endpoints. If multiple or no container runtimes are detected `kubeadm` will throw an error and will request that you specify which one you want to use.

### containerd
This section outlines the necessary steps to use containerd as CRI runtime.To install containerd on your system, follow the instructions on getting started with containerd. Return to this step once you've created a valid `config.toml` configuration file. You can find this file under the path `/etc/containerd/config.toml`.

On Linux the default CRI socket for containerd is `/run/containerd/containerd.sock`.

Follow the installation process.
1. Set up Docker's apt repository.

```
# Add Docker's official GPG key:
sudo apt-get update
sudo apt-get install ca-certificates curl
sudo install -m 0755 -d /etc/apt/keyrings
sudo curl -fsSL https://download.docker.com/linux/ubuntu/gpg -o /etc/apt/keyrings/docker.asc
sudo chmod a+r /etc/apt/keyrings/docker.asc

# Add the repository to Apt sources:
echo \
  "deb [arch=$(dpkg --print-architecture) signed-by=/etc/apt/keyrings/docker.asc] https://download.docker.com/linux/ubuntu \
  $(. /etc/os-release && echo "$VERSION_CODENAME") stable" | \
  sudo tee /etc/apt/sources.list.d/docker.list > /dev/null
sudo apt-get update
```

2. Install containerd
```
sudo apt-get install containerd.io
```

3. Run the following commands to configure containerd
```
sudo mkdir -p /etc/containerd
sudo containerd config default | sudo tee /etc/containerd/config.toml
```

4. Verify that the configuration is correct, particularly the plugins."io.containerd.grpc.v1.cri" section. Ensure the sandbox_image is properly set:
```
[plugins."io.containerd.grpc.v1.cri".containerd]
  snapshotter = "overlayfs"
[plugins."io.containerd.grpc.v1.cri".containerd.runtimes.runc.options]
  SystemdCgroup = true
```

5. Restart containerd
```
sudo systemctl restart containerd
sudo systemctl enable containerd
systemctl status containerd
```

6. Enable IP Forwarding
Enable IP forwarding temporarily and permanently:

a. Temporary option
```
echo 1 | sudo tee /proc/sys/net/ipv4/ip_forward
```

b. Permanently
Add the following line to /etc/sysctl.conf:
```
sudo sh -c "echo 'net.ipv4.ip_forward = 1' >> /etc/sysctl.conf"
```

Apply the changes:
```
sudo sysctl -p
```

3. Validate Setup
After making these changes, validate the container runtime and IP forwarding:

a. Validate Containerd
Use crictl to check the containerd status:
```
sudo crictl info
```
This should return details about the container runtime if it is correctly configured.

b. Validate IP Forwarding
Verify that IP forwarding is enabled:
```
cat /proc/sys/net/ipv4/ip_forward
```

## Install Kubectl
### Step 1
Download the latest release with the command:

```
curl -LO "https://dl.k8s.io/release/$(curl -L -s https://dl.k8s.io/release/stable.txt)/bin/linux/amd64/kubectl"
```
### Step 2
Validate the binary (optional)

```
curl -LO "https://dl.k8s.io/release/$(curl -L -s https://dl.k8s.io/release/stable.txt)/bin/linux/amd64/kubectl.sha256"
```

Validate the kubectl binary against the checksum file:
```
echo "$(cat kubectl.sha256)  kubectl" | sha256sum --check
```

### Step 3
Install kubectl
```
sudo install -o root -g root -m 0755 kubectl /usr/local/bin/kubectl
```

### Step 4
Test to ensure the version you installed is up-to-date:
```
kubectl version --client
```

Or use this for detailed view of version:

```
kubectl version --client --output=yaml
```

## Install Kubeadm
These instructions are for Kubernetes v1.30.

1. Update the apt package index and install packages needed to use the Kubernetes apt repository:

```
sudo apt-get update
# apt-transport-https may be a dummy package; if so, you can skip that package
sudo apt-get install -y apt-transport-https ca-certificates curl gpg
```

2. Download the public signing key for the Kubernetes package repositories. The same signing key is used for all repositories so you can disregard the version in the URL:

```
# If the directory `/etc/apt/keyrings` does not exist, it should be created before the curl command, read the note below.
# sudo mkdir -p -m 755 /etc/apt/keyrings
curl -fsSL https://pkgs.k8s.io/core:/stable:/v1.30/deb/Release.key | sudo gpg --dearmor -o /etc/apt/keyrings/kubernetes-apt-keyring.gpg
```

3. Add the appropriate Kubernetes apt repository. Please note that this repository have packages only for Kubernetes 1.30; for other Kubernetes minor versions, you need to change the Kubernetes minor version in the URL to match your desired minor version (you should also check that you are reading the documentation for the version of Kubernetes that you plan to install).

```
# This overwrites any existing configuration in /etc/apt/sources.list.d/kubernetes.list
echo 'deb [signed-by=/etc/apt/keyrings/kubernetes-apt-keyring.gpg] https://pkgs.k8s.io/core:/stable:/v1.30/deb/ /' | sudo tee /etc/apt/sources.list.d/kubernetes.list
```

4. Update the apt package index, install kubelet, kubeadm and kubectl, and pin their version:

```
sudo apt-get update
sudo apt-get install kubelet kubeadm kubectl
sudo apt-mark hold kubelet kubeadm kubectl
```

5. (Optional) Enable the kubelet service before running kubeadm:
```
sudo systemctl enable --now kubelet
```

## Creating a cluster with kubeadm

### Network setup
kubeadm similarly to other Kubernetes components tries to find a usable IP on the network interfaces associated with a default gateway on a host. Such an IP is then used for the advertising and/or listening performed by a component.

To find out what this IP is on a Linux host you can use:

```
ip route show # Look for a line starting with "default via"
```

Kubernetes components do not accept custom network interface as an option, therefore a custom IP address must be passed as a flag to all components instances that need such a custom configuration.

To configure the API server advertise address for control plane nodes created with both init and join, the flag `--apiserver-advertise-address` can be used. Preferably, this option can be set in the kubeadm API as InitConfiguration.localAPIEndpoint and JoinConfiguration.controlPlane.localAPIEndpoint.

For kubelets on all nodes, the --node-ip option can be passed in .nodeRegistration.kubeletExtraArgs inside a kubeadm configuration file (InitConfiguration or JoinConfiguration).

For dual-stack see Dual-stack support with kubeadm.

The IP addresses that you assign to control plane components become part of their X.509 certificates' subject alternative name fields. Changing these IP addresses would require signing new certificates and restarting the affected components, so that the change in certificate files is reflected. 

### Initializing your control-plane node
The control-plane node is the machine where the control plane components run, including etcd (the cluster database) and the API Server (which the kubectl command line tool communicates with).

(Recommended) If you have plans to upgrade this single control-plane kubeadm cluster to high availability you should specify the `--control-plane-endpoint` to set the shared endpoint for all control-plane nodes. Such an endpoint can be either a DNS name or an IP address of a load-balancer.
Choose a Pod network add-on, and verify whether it requires any arguments to be passed to kubeadm init. Depending on which third-party provider you choose, you might need to set the `--pod-network-cidr` to a provider-specific value. 
(Optional) kubeadm tries to detect the container runtime by using a list of well known endpoints. To use different container runtime or if there are more than one installed on the provisioned node, specify the `--cri-socket` argument to kubeadm. 
To initialize the control-plane node run:

```
kubeadm init <args>
```

### Considerations about apiserver-advertise-address and ControlPlaneEndpoint 
While `--apiserver-advertise-address` can be used to set the advertise address for this particular control-plane node's API server, `--control-plane-endpoint` can be used to set the shared endpoint for all control-plane nodes.

`--control-plane-endpoint` allows both IP addresses and DNS names that can map to IP addresses. Please contact your network administrator to evaluate possible solutions with respect to such mapping.

Here is an example mapping:

`192.168.0.193 cluster-endpoint`

Where `192.168.0.193` is the IP address of this node and `cluster-endpoint` is a custom DNS name that maps to this IP. This will allow you to pass `--control-plane-endpoint=cluster-endpoint` to kubeadm init and pass the same DNS name to kubeadm join. Later you can modify `cluster-endpoint` to point to the address of your load-balancer in an high availability scenario.

Turning a single control plane cluster created without `--control-plane-endpoint` into a highly available cluster is not supported by kubeadm.

So write the following command.
```
sudo kubeadm init --cri-socket /var/run/containerd/containerd.sock --v=5
```

It'll produce output like the following snippet.
```
To start using your cluster, you need to run the following as a regular user:

  mkdir -p $HOME/.kube
  sudo cp -i /etc/kubernetes/admin.conf $HOME/.kube/config
  sudo chown $(id -u):$(id -g) $HOME/.kube/config

Alternatively, if you are the root user, you can run:

  export KUBECONFIG=/etc/kubernetes/admin.conf

You should now deploy a pod network to the cluster.
Run "kubectl apply -f [podnetwork].yaml" with one of the options listed at:
  https://kubernetes.io/docs/concepts/cluster-administration/addons/

Then you can join any number of worker nodes by running the following on each as root:

kubeadm join 192.168.0.193:6443 --token 1rc7cy.ln076tz43nj0ghjr \
	--discovery-token-ca-cert-hash sha256:a6c7f7d99f35fec5f274d50fd1120bebd7c518b4eaa8174ebcba87fbd33c7677 
```

### Installing a Pod network add-on
This section contains important information about networking setup and deployment order. Read all of this advice carefully before proceeding.

You must deploy a Container Network Interface (CNI) based Pod network add-on so that your Pods can communicate with each other. Cluster DNS (CoreDNS) will not start up before a network is installed.

Take care that your Pod network must not overlap with any of the host networks: you are likely to see problems if there is any overlap. (If you find a collision between your network plugin's preferred Pod network and some of your host networks, you should think of a suitable CIDR block to use instead, then use that during kubeadm init with --pod-network-cidr and as a replacement in your network plugin's YAML).

By default, kubeadm sets up your cluster to use and enforce use of RBAC (role based access control). Make sure that your Pod network plugin supports RBAC, and so do any manifests that you use to deploy it.

If you want to use IPv6--either dual-stack, or single-stack IPv6 only networking--for your cluster, make sure that your Pod network plugin supports IPv6. IPv6 support was added to CNI in v0.6.0.

So install calico on kubernetes cluster by following the [link](https://docs.tigera.io/calico/latest/getting-started/kubernetes/quickstart)

Write the following command:
```
kubectl create -f https://raw.githubusercontent.com/projectcalico/calico/v3.28.0/manifests/tigera-operator.yaml
```


### Enable API Server
Check the Kubernetes API server's address and port configuration. Typically, the API server runs on port 6443. Make sure the kube-apiserver is correctly configured to bind to the appropriate address.You can also specify the API server's address explicitly when using kubectl:

```
wget https://raw.githubusercontent.com/projectcalico/calico/v3.28.0/manifests/tigera-operator.yaml
sudo kubectl apply -f tigera-operator.yaml -validate=false
```

### Kubernetes Dashboard Install helm
```
https://helm.sh/docs/intro/install/
https://github.com/kubernetes/dashboard
https://github.com/kubernetes/dashboard/blob/master/docs/user/access-control/creating-sample-user.md
```
