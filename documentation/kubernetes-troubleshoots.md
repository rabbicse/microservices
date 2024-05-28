```
master@master:~$ cat /proc/sys/net/ipv4/ip_forward
1
master@master:~$ sudo kubeadm init --cri-socket unix:///var/run/containerd/containerd.sock --v=5
I0520 16:54:02.846031    6168 interface.go:432] Looking for default routes with IPv4 addresses
I0520 16:54:02.846145    6168 interface.go:437] Default route transits interface "ens33"
I0520 16:54:02.846348    6168 interface.go:209] Interface ens33 is up
I0520 16:54:02.846570    6168 interface.go:257] Interface "ens33" has 2 addresses :[192.168.0.193/24 fe80::20c:29ff:fe09:602d/64].
I0520 16:54:02.846671    6168 interface.go:224] Checking addr  192.168.0.193/24.
I0520 16:54:02.846729    6168 interface.go:231] IP found 192.168.0.193
I0520 16:54:02.846792    6168 interface.go:263] Found valid IPv4 address 192.168.0.193 for interface "ens33".
I0520 16:54:02.846806    6168 interface.go:443] Found active IP 192.168.0.193 
I0520 16:54:02.846828    6168 kubelet.go:196] the value of KubeletConfiguration.cgroupDriver is empty; setting it to "systemd"
I0520 16:54:02.853132    6168 version.go:187] fetching Kubernetes version from URL: https://dl.k8s.io/release/stable-1.txt
[init] Using Kubernetes version: v1.30.1
[preflight] Running pre-flight checks
I0520 16:54:04.759499    6168 checks.go:561] validating Kubernetes and kubeadm version
I0520 16:54:04.759558    6168 checks.go:166] validating if the firewall is enabled and active
I0520 16:54:04.773820    6168 checks.go:201] validating availability of port 6443
I0520 16:54:04.774608    6168 checks.go:201] validating availability of port 10259
I0520 16:54:04.774645    6168 checks.go:201] validating availability of port 10257
I0520 16:54:04.774672    6168 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-apiserver.yaml
I0520 16:54:04.774687    6168 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-controller-manager.yaml
I0520 16:54:04.774698    6168 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-scheduler.yaml
I0520 16:54:04.774708    6168 checks.go:278] validating the existence of file /etc/kubernetes/manifests/etcd.yaml
I0520 16:54:04.774718    6168 checks.go:428] validating if the connectivity type is via proxy or direct
I0520 16:54:04.774737    6168 checks.go:467] validating http connectivity to first IP address in the CIDR
I0520 16:54:04.774756    6168 checks.go:467] validating http connectivity to first IP address in the CIDR
I0520 16:54:04.774764    6168 checks.go:102] validating the container runtime
I0520 16:54:04.801432    6168 checks.go:637] validating whether swap is enabled or not
I0520 16:54:04.801552    6168 checks.go:368] validating the presence of executable crictl
I0520 16:54:04.801583    6168 checks.go:368] validating the presence of executable conntrack
I0520 16:54:04.801598    6168 checks.go:368] validating the presence of executable ip
I0520 16:54:04.801615    6168 checks.go:368] validating the presence of executable iptables
I0520 16:54:04.801632    6168 checks.go:368] validating the presence of executable mount
I0520 16:54:04.801647    6168 checks.go:368] validating the presence of executable nsenter
I0520 16:54:04.801660    6168 checks.go:368] validating the presence of executable ebtables
I0520 16:54:04.801675    6168 checks.go:368] validating the presence of executable ethtool
I0520 16:54:04.801687    6168 checks.go:368] validating the presence of executable socat
I0520 16:54:04.801701    6168 checks.go:368] validating the presence of executable tc
I0520 16:54:04.801713    6168 checks.go:368] validating the presence of executable touch
I0520 16:54:04.801730    6168 checks.go:514] running all checks
I0520 16:54:04.820019    6168 checks.go:399] checking whether the given node name is valid and reachable using net.LookupHost
I0520 16:54:04.820147    6168 checks.go:603] validating kubelet version
I0520 16:54:04.893094    6168 checks.go:128] validating if the "kubelet" service is enabled and active
I0520 16:54:04.907487    6168 checks.go:201] validating availability of port 10250
I0520 16:54:04.907575    6168 checks.go:327] validating the contents of file /proc/sys/net/ipv4/ip_forward
I0520 16:54:04.907635    6168 checks.go:201] validating availability of port 2379
I0520 16:54:04.907670    6168 checks.go:201] validating availability of port 2380
I0520 16:54:04.907698    6168 checks.go:241] validating the existence and emptiness of directory /var/lib/etcd
[preflight] Pulling images required for setting up a Kubernetes cluster
[preflight] This might take a minute or two, depending on the speed of your internet connection
[preflight] You can also perform this action in beforehand using 'kubeadm config images pull'
I0520 16:54:04.907845    6168 checks.go:830] using image pull policy: IfNotPresent
W0520 16:54:04.936302    6168 checks.go:844] detected that the sandbox image "registry.k8s.io/pause:3.6" of the container runtime is inconsistent with that used by kubeadm.It is recommended to use "registry.k8s.io/pause:3.9" as the CRI sandbox image.
I0520 16:54:04.972980    6168 checks.go:870] pulling: registry.k8s.io/kube-apiserver:v1.30.1
I0520 16:54:36.264547    6168 checks.go:870] pulling: registry.k8s.io/kube-controller-manager:v1.30.1
I0520 16:55:03.572763    6168 checks.go:870] pulling: registry.k8s.io/kube-scheduler:v1.30.1
I0520 16:55:18.821690    6168 checks.go:870] pulling: registry.k8s.io/kube-proxy:v1.30.1
I0520 16:55:42.056638    6168 checks.go:870] pulling: registry.k8s.io/coredns/coredns:v1.11.1
I0520 16:56:20.898548    6168 checks.go:870] pulling: registry.k8s.io/pause:3.9
I0520 16:56:24.657121    6168 checks.go:870] pulling: registry.k8s.io/etcd:3.5.12-0
[certs] Using certificateDir folder "/etc/kubernetes/pki"
I0520 16:57:19.293795    6168 certs.go:112] creating a new certificate authority for ca
[certs] Generating "ca" certificate and key
I0520 16:57:19.578016    6168 certs.go:483] validating certificate period for ca certificate
[certs] Generating "apiserver" certificate and key
[certs] apiserver serving cert is signed for DNS names [kubernetes kubernetes.default kubernetes.default.svc kubernetes.default.svc.cluster.local master] and IPs [10.96.0.1 192.168.0.193]
[certs] Generating "apiserver-kubelet-client" certificate and key
I0520 16:57:19.727446    6168 certs.go:112] creating a new certificate authority for front-proxy-ca
[certs] Generating "front-proxy-ca" certificate and key
I0520 16:57:19.884802    6168 certs.go:483] validating certificate period for front-proxy-ca certificate
[certs] Generating "front-proxy-client" certificate and key
I0520 16:57:19.999154    6168 certs.go:112] creating a new certificate authority for etcd-ca
[certs] Generating "etcd/ca" certificate and key
I0520 16:57:20.068495    6168 certs.go:483] validating certificate period for etcd/ca certificate
[certs] Generating "etcd/server" certificate and key
[certs] etcd/server serving cert is signed for DNS names [localhost master] and IPs [192.168.0.193 127.0.0.1 ::1]
[certs] Generating "etcd/peer" certificate and key
[certs] etcd/peer serving cert is signed for DNS names [localhost master] and IPs [192.168.0.193 127.0.0.1 ::1]
[certs] Generating "etcd/healthcheck-client" certificate and key
[certs] Generating "apiserver-etcd-client" certificate and key
I0520 16:57:20.756660    6168 certs.go:78] creating new public/private key files for signing service account users
[certs] Generating "sa" key and public key
[kubeconfig] Using kubeconfig folder "/etc/kubernetes"
I0520 16:57:20.912823    6168 kubeconfig.go:112] creating kubeconfig file for admin.conf
[kubeconfig] Writing "admin.conf" kubeconfig file
I0520 16:57:21.062375    6168 kubeconfig.go:112] creating kubeconfig file for super-admin.conf
[kubeconfig] Writing "super-admin.conf" kubeconfig file
I0520 16:57:21.201864    6168 kubeconfig.go:112] creating kubeconfig file for kubelet.conf
[kubeconfig] Writing "kubelet.conf" kubeconfig file
I0520 16:57:21.323677    6168 kubeconfig.go:112] creating kubeconfig file for controller-manager.conf
[kubeconfig] Writing "controller-manager.conf" kubeconfig file
I0520 16:57:21.560895    6168 kubeconfig.go:112] creating kubeconfig file for scheduler.conf
[kubeconfig] Writing "scheduler.conf" kubeconfig file
[etcd] Creating static Pod manifest for local etcd in "/etc/kubernetes/manifests"
I0520 16:57:21.699135    6168 local.go:65] [etcd] wrote Static Pod manifest for a local etcd member to "/etc/kubernetes/manifests/etcd.yaml"
[control-plane] Using manifest folder "/etc/kubernetes/manifests"
[control-plane] Creating static Pod manifest for "kube-apiserver"
I0520 16:57:21.700169    6168 manifests.go:103] [control-plane] getting StaticPodSpecs
I0520 16:57:21.700460    6168 certs.go:483] validating certificate period for CA certificate
I0520 16:57:21.700532    6168 manifests.go:129] [control-plane] adding volume "ca-certs" for component "kube-apiserver"
I0520 16:57:21.700544    6168 manifests.go:129] [control-plane] adding volume "etc-ca-certificates" for component "kube-apiserver"
I0520 16:57:21.700553    6168 manifests.go:129] [control-plane] adding volume "k8s-certs" for component "kube-apiserver"
I0520 16:57:21.700561    6168 manifests.go:129] [control-plane] adding volume "usr-local-share-ca-certificates" for component "kube-apiserver"
I0520 16:57:21.700569    6168 manifests.go:129] [control-plane] adding volume "usr-share-ca-certificates" for component "kube-apiserver"
I0520 16:57:21.701330    6168 manifests.go:158] [control-plane] wrote static Pod manifest for component "kube-apiserver" to "/etc/kubernetes/manifests/kube-apiserver.yaml"
[control-plane] Creating static Pod manifest for "kube-controller-manager"
I0520 16:57:21.701431    6168 manifests.go:103] [control-plane] getting StaticPodSpecs
I0520 16:57:21.701593    6168 manifests.go:129] [control-plane] adding volume "ca-certs" for component "kube-controller-manager"
I0520 16:57:21.701637    6168 manifests.go:129] [control-plane] adding volume "etc-ca-certificates" for component "kube-controller-manager"
I0520 16:57:21.701648    6168 manifests.go:129] [control-plane] adding volume "flexvolume-dir" for component "kube-controller-manager"
I0520 16:57:21.701657    6168 manifests.go:129] [control-plane] adding volume "k8s-certs" for component "kube-controller-manager"
I0520 16:57:21.701666    6168 manifests.go:129] [control-plane] adding volume "kubeconfig" for component "kube-controller-manager"
I0520 16:57:21.701674    6168 manifests.go:129] [control-plane] adding volume "usr-local-share-ca-certificates" for component "kube-controller-manager"
I0520 16:57:21.701683    6168 manifests.go:129] [control-plane] adding volume "usr-share-ca-certificates" for component "kube-controller-manager"
I0520 16:57:21.702307    6168 manifests.go:158] [control-plane] wrote static Pod manifest for component "kube-controller-manager" to "/etc/kubernetes/manifests/kube-controller-manager.yaml"
[control-plane] Creating static Pod manifest for "kube-scheduler"
I0520 16:57:21.702367    6168 manifests.go:103] [control-plane] getting StaticPodSpecs
I0520 16:57:21.702499    6168 manifests.go:129] [control-plane] adding volume "kubeconfig" for component "kube-scheduler"
I0520 16:57:21.702930    6168 manifests.go:158] [control-plane] wrote static Pod manifest for component "kube-scheduler" to "/etc/kubernetes/manifests/kube-scheduler.yaml"
I0520 16:57:21.702981    6168 kubelet.go:68] Stopping the kubelet
[kubelet-start] Writing kubelet environment file with flags to file "/var/lib/kubelet/kubeadm-flags.env"
[kubelet-start] Writing kubelet configuration to file "/var/lib/kubelet/config.yaml"
[kubelet-start] Starting the kubelet
[wait-control-plane] Waiting for the kubelet to boot up the control plane as static Pods from directory "/etc/kubernetes/manifests"
[kubelet-check] Waiting for a healthy kubelet. This can take up to 4m0s
[kubelet-check] The kubelet is healthy after 1.001928589s
[api-check] Waiting for a healthy API server. This can take up to 4m0s
[api-check] The API server is healthy after 7.003839072s
I0520 16:57:30.016658    6168 kubeconfig.go:608] ensuring that the ClusterRoleBinding for the kubeadm:cluster-admins Group exists
I0520 16:57:30.022163    6168 kubeconfig.go:681] creating the ClusterRoleBinding for the kubeadm:cluster-admins Group by using super-admin.conf
I0520 16:57:30.047017    6168 uploadconfig.go:112] [upload-config] Uploading the kubeadm ClusterConfiguration to a ConfigMap
[upload-config] Storing the configuration used in ConfigMap "kubeadm-config" in the "kube-system" Namespace
I0520 16:57:30.065597    6168 uploadconfig.go:126] [upload-config] Uploading the kubelet component config to a ConfigMap
[kubelet] Creating a ConfigMap "kubelet-config" in namespace kube-system with the configuration for the kubelets in the cluster
I0520 16:57:30.075742    6168 uploadconfig.go:131] [upload-config] Preserving the CRISocket information for the control-plane node
I0520 16:57:30.075766    6168 patchnode.go:31] [patchnode] Uploading the CRI Socket information "unix:///var/run/containerd/containerd.sock" to the Node API object "master" as an annotation
[upload-certs] Skipping phase. Please see --upload-certs
[mark-control-plane] Marking the node master as control-plane by adding the labels: [node-role.kubernetes.io/control-plane node.kubernetes.io/exclude-from-external-load-balancers]
[mark-control-plane] Marking the node master as control-plane by adding the taints [node-role.kubernetes.io/control-plane:NoSchedule]
[bootstrap-token] Using token: 1rc7cy.ln076tz43nj0ghjr
[bootstrap-token] Configuring bootstrap tokens, cluster-info ConfigMap, RBAC Roles
[bootstrap-token] Configured RBAC rules to allow Node Bootstrap tokens to get nodes
[bootstrap-token] Configured RBAC rules to allow Node Bootstrap tokens to post CSRs in order for nodes to get long term certificate credentials
[bootstrap-token] Configured RBAC rules to allow the csrapprover controller automatically approve CSRs from a Node Bootstrap Token
[bootstrap-token] Configured RBAC rules to allow certificate rotation for all node client certificates in the cluster
[bootstrap-token] Creating the "cluster-info" ConfigMap in the "kube-public" namespace
I0520 16:57:30.114888    6168 clusterinfo.go:47] [bootstrap-token] loading admin kubeconfig
I0520 16:57:30.115810    6168 clusterinfo.go:58] [bootstrap-token] copying the cluster from admin.conf to the bootstrap kubeconfig
I0520 16:57:30.116307    6168 clusterinfo.go:70] [bootstrap-token] creating/updating ConfigMap in kube-public namespace
I0520 16:57:30.120412    6168 clusterinfo.go:84] creating the RBAC rules for exposing the cluster-info ConfigMap in the kube-public namespace
I0520 16:57:30.218606    6168 request.go:629] Waited for 97.779862ms due to client-side throttling, not priority and fairness, request: POST:https://192.168.0.193:6443/apis/rbac.authorization.k8s.io/v1/namespaces/kube-public/roles?timeout=10s
I0520 16:57:30.418002    6168 request.go:629] Waited for 184.839738ms due to client-side throttling, not priority and fairness, request: POST:https://192.168.0.193:6443/apis/rbac.authorization.k8s.io/v1/namespaces/kube-public/rolebindings?timeout=10s
I0520 16:57:30.430992    6168 kubeletfinalize.go:91] [kubelet-finalize] Assuming that kubelet client certificate rotation is enabled: found "/var/lib/kubelet/pki/kubelet-client-current.pem"
[kubelet-finalize] Updating "/etc/kubernetes/kubelet.conf" to point to a rotatable kubelet client certificate and key
I0520 16:57:30.437793    6168 kubeletfinalize.go:145] [kubelet-finalize] Restarting the kubelet to enable client certificate rotation
[addons] Applied essential addon: CoreDNS
I0520 16:57:31.055883    6168 request.go:629] Waited for 190.369586ms due to client-side throttling, not priority and fairness, request: POST:https://192.168.0.193:6443/api/v1/namespaces/kube-system/serviceaccounts?timeout=10s
I0520 16:57:31.217865    6168 request.go:629] Waited for 149.893819ms due to client-side throttling, not priority and fairness, request: POST:https://192.168.0.193:6443/apis/rbac.authorization.k8s.io/v1/namespaces/kube-system/roles?timeout=10s
I0520 16:57:31.417935    6168 request.go:629] Waited for 183.889785ms due to client-side throttling, not priority and fairness, request: POST:https://192.168.0.193:6443/apis/rbac.authorization.k8s.io/v1/namespaces/kube-system/rolebindings?timeout=10s
[addons] Applied essential addon: kube-proxy

Your Kubernetes control-plane has initialized successfully!

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
master@master:~$ sudo kubeadm init --cri-socket unix:///var/run/containerd/containerd.sock --v=5^C
master@master:~$ ^C
master@master:~$ mkdir -p $HOME/.kube
master@master:~$ sudo cp -i /etc/kubernetes/admin.conf $HOME/.kube/config
[sudo] password for master: 
master@master:~$ sudo chown $(id -u):$(id -g) $HOME/.kube/config
master@master:~$ sudo export KUBECONFIG=/etc/kubernetes/admin.conf
sudo: export: command not found
master@master:~$ export KUBECONFIG=/etc/kubernetes/admin.conf
master@master:~$ kubectl cluster-info
error: error loading config file "/etc/kubernetes/admin.conf": open /etc/kubernetes/admin.conf: permission denied
master@master:~$ sudo kubectl cluster-info
E0520 17:35:40.547914    7433 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:35:40.548609    7433 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:35:40.550415    7433 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:35:40.550824    7433 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:35:40.552483    7433 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused

To further debug and diagnose cluster problems, use 'kubectl cluster-info dump'.
The connection to the server localhost:8080 was refused - did you specify the right host or port?
master@master:~$ kubectl create -f https://raw.githubusercontent.com/projectcalico/calico/v3.28.0/manifests/tigera-operator.yaml
error: error loading config file "/etc/kubernetes/admin.conf": open /etc/kubernetes/admin.conf: permission denied
master@master:~$ sudo kubectl create -f https://raw.githubusercontent.com/projectcalico/calico/v3.28.0/manifests/tigera-operator.yaml
error: error validating "https://raw.githubusercontent.com/projectcalico/calico/v3.28.0/manifests/tigera-operator.yaml": error validating data: failed to download openapi: Get "http://localhost:8080/openapi/v2?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused; if you choose to ignore these errors, turn validation off with --validate=false
master@master:~$ sudo systemctl status kubelet
● kubelet.service - kubelet: The Kubernetes Node Agent
     Loaded: loaded (/usr/lib/systemd/system/kubelet.service; enabled; preset: enabled)
    Drop-In: /usr/lib/systemd/system/kubelet.service.d
             └─10-kubeadm.conf
     Active: active (running) since Mon 2024-05-20 16:57:30 UTC; 46min ago
       Docs: https://kubernetes.io/docs/
   Main PID: 6926 (kubelet)
      Tasks: 13 (limit: 9388)
     Memory: 35.0M (peak: 36.2M)
        CPU: 1min 41.256s
     CGroup: /system.slice/kubelet.service
             └─6926 /usr/bin/kubelet --bootstrap-kubeconfig=/etc/kubernetes/bootstrap-kubelet.conf --kubeconfig=/etc/kubernetes/kubelet.conf --config=/var/lib/kubelet/config.yaml --container-runtime-endpoint=unix:///var/run/containerd/containerd.sock --pod-infra-container-image=registry.k8s.io/pause:3.9

May 20 17:43:12 master kubelet[6926]: E0520 17:43:12.284354    6926 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 17:43:17 master kubelet[6926]: E0520 17:43:17.288308    6926 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 17:43:22 master kubelet[6926]: E0520 17:43:22.291674    6926 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 17:43:27 master kubelet[6926]: E0520 17:43:27.295025    6926 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 17:43:32 master kubelet[6926]: E0520 17:43:32.296691    6926 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 17:43:37 master kubelet[6926]: E0520 17:43:37.298701    6926 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 17:43:42 master kubelet[6926]: E0520 17:43:42.302588    6926 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 17:43:47 master kubelet[6926]: E0520 17:43:47.306067    6926 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 17:43:52 master kubelet[6926]: E0520 17:43:52.309201    6926 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 17:43:57 master kubelet[6926]: E0520 17:43:57.311822    6926 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
master@master:~$ sudo kubectl get nodes
E0520 17:44:57.099630    7520 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:44:57.101671    7520 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:44:57.102348    7520 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:44:57.103686    7520 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:44:57.104082    7520 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
The connection to the server localhost:8080 was refused - did you specify the right host or port?
master@master:~$ sudo kubectl get pods --all-namespaces
E0520 17:45:14.499791    7530 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:45:14.500101    7530 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:45:14.501666    7530 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:45:14.501932    7530 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:45:14.503438    7530 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
The connection to the server localhost:8080 was refused - did you specify the right host or port?
master@master:~$ sudo systemctl status kubelet
● kubelet.service - kubelet: The Kubernetes Node Agent
     Loaded: loaded (/usr/lib/systemd/system/kubelet.service; enabled; preset: enabled)
    Drop-In: /usr/lib/systemd/system/kubelet.service.d
             └─10-kubeadm.conf
     Active: active (running) since Mon 2024-05-20 16:57:30 UTC; 47min ago
       Docs: https://kubernetes.io/docs/
   Main PID: 6926 (kubelet)
      Tasks: 13 (limit: 9388)
     Memory: 35.0M (peak: 36.2M)
        CPU: 1min 45.669s
     CGroup: /system.slice/kubelet.service
             └─6926 /usr/bin/kubelet --bootstrap-kubeconfig=/etc/kubernetes/bootstrap-kubelet.conf --kubeconfig=/etc/kubernetes/kubelet.conf --config=/var/lib/kubelet/config.yaml --container-runtime-endpoint=unix:///var/run/containerd/containerd.sock --pod-infra-container-image=registry.k8s.io/pause:3.9

May 20 17:44:37 master kubelet[6926]: E0520 17:44:37.336928    6926 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 17:44:42 master kubelet[6926]: E0520 17:44:42.340981    6926 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 17:44:47 master kubelet[6926]: E0520 17:44:47.346910    6926 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 17:44:52 master kubelet[6926]: E0520 17:44:52.351022    6926 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 17:44:57 master kubelet[6926]: E0520 17:44:57.354109    6926 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 17:45:02 master kubelet[6926]: E0520 17:45:02.357014    6926 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 17:45:07 master kubelet[6926]: E0520 17:45:07.362072    6926 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 17:45:12 master kubelet[6926]: E0520 17:45:12.364930    6926 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 17:45:17 master kubelet[6926]: E0520 17:45:17.366922    6926 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 17:45:22 master kubelet[6926]: E0520 17:45:22.370151    6926 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
master@master:~$ kubectl --server=https://<master-node-ip>:6443 create -f https://raw.githubusercontent.com/projectcalico/calico/v3.28.0/manifests/tigera-operator.yaml
-bash: master-node-ip: No such file or directory
master@master:~$ kubectl --server=https://192.168.0.193:6443 create -f https://raw.githubusercontent.com/projectcalico/calico/v3.28.0/manifests/tigera-operator.yaml
error: error loading config file "/etc/kubernetes/admin.conf": open /etc/kubernetes/admin.conf: permission denied
master@master:~$ sudo kubectl --server=https://192.168.0.193:6443 create -f https://raw.githubusercontent.com/projectcalico/calico/v3.28.0/manifests/tigera-operator.yaml
Please enter Username: master
Please enter Password: error: error validating "https://raw.githubusercontent.com/projectcalico/calico/v3.28.0/manifests/tigera-operator.yaml": error validating data: failed to download openapi: Get "https://192.168.0.193:6443/openapi/v2?timeout=32s": tls: failed to verify certificate: x509: certificate signed by unknown authority; if you choose to ignore these errors, turn validation off with --validate=false
master@master:~$ wget https://raw.githubusercontent.com/projectcalico/calico/v3.28.0/manifests/tigera-operator.yaml
--2024-05-20 17:48:51--  https://raw.githubusercontent.com/projectcalico/calico/v3.28.0/manifests/tigera-operator.yaml
Resolving raw.githubusercontent.com (raw.githubusercontent.com)... 185.199.111.133, 185.199.109.133, 185.199.110.133, ...
Connecting to raw.githubusercontent.com (raw.githubusercontent.com)|185.199.111.133|:443... connected.
HTTP request sent, awaiting response... 200 OK
Length: 1765780 (1.7M) [text/plain]
Saving to: ‘tigera-operator.yaml’

tigera-operator.yaml                           100%[=================================================================================================>]   1.68M  5.76MB/s    in 0.3s    

2024-05-20 17:48:52 (5.76 MB/s) - ‘tigera-operator.yaml’ saved [1765780/1765780]

master@master:~$ kubectl apply -f tigera-operator.yaml
error: error loading config file "/etc/kubernetes/admin.conf": open /etc/kubernetes/admin.conf: permission denied
master@master:~$ sudo kubectl apply -f tigera-operator.yaml
error: error validating "tigera-operator.yaml": error validating data: failed to download openapi: Get "http://localhost:8080/openapi/v2?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused; if you choose to ignore these errors, turn validation off with --validate=false
master@master:~$ sudo kubectl apply -f tigera-operator.yaml --validate=false
E0520 17:49:57.010817    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.012130    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.013061    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.015545    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.015964    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.018683    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.019304    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.025339    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.031268    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.032115    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.034189    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.035104    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.037148    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.038017    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.040003    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.040595    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.044197    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.049428    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.050316    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.058122    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.058775    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.139853    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.141542    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.141958    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.145634    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.147137    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:49:57.148317    7604 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
master@master:~$ sudo systemctl restart kubelet
master@master:~$ sudo kubectl apply -f tigera-operator.yaml --validate=false
E0520 17:54:00.047746    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.050258    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.051169    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.052420    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.053188    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.055919    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.056845    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.065543    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.069551    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.070285    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.072145    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.073081    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.075526    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.076281    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.078748    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.079675    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.081139    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.087950    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.088994    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.096080    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.097231    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.176110    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.177127    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.177513    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.179636    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.179898    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:54:00.181833    7672 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
master@master:~$ watch kubectl get pods -n calico-system
master@master:~$ sudo watch kubectl get pods -n calico-system
master@master:~$ kubectl get nodes -o wide
error: error loading config file "/etc/kubernetes/admin.conf": open /etc/kubernetes/admin.conf: permission denied
master@master:~$ sudo kubectl get nodes -o wide
E0520 17:57:05.572287    7855 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:57:05.572668    7855 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:57:05.574019    7855 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:57:05.574456    7855 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:57:05.577745    7855 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
The connection to the server localhost:8080 was refused - did you specify the right host or port?
master@master:~$ kubectl cluster-info
error: error loading config file "/etc/kubernetes/admin.conf": open /etc/kubernetes/admin.conf: permission denied
master@master:~$ sudo kubectl cluster-info
E0520 17:57:45.852481    7880 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:57:45.852698    7880 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:57:45.854100    7880 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:57:45.854452    7880 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 17:57:45.855837    7880 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused

To further debug and diagnose cluster problems, use 'kubectl cluster-info dump'.
The connection to the server localhost:8080 was refused - did you specify the right host or port?
master@master:~$ sudo kubeadm init --cri-socket unix:///var/run/containerd/containerd.sock --v=5 --pod-network-cidr=10.244.0.0/16
I0520 17:59:23.001539    7898 interface.go:432] Looking for default routes with IPv4 addresses
I0520 17:59:23.001577    7898 interface.go:437] Default route transits interface "ens33"
I0520 17:59:23.001706    7898 interface.go:209] Interface ens33 is up
I0520 17:59:23.001753    7898 interface.go:257] Interface "ens33" has 2 addresses :[192.168.0.193/24 fe80::20c:29ff:fe09:602d/64].
I0520 17:59:23.001762    7898 interface.go:224] Checking addr  192.168.0.193/24.
I0520 17:59:23.001769    7898 interface.go:231] IP found 192.168.0.193
I0520 17:59:23.001783    7898 interface.go:263] Found valid IPv4 address 192.168.0.193 for interface "ens33".
I0520 17:59:23.001789    7898 interface.go:443] Found active IP 192.168.0.193 
I0520 17:59:23.001802    7898 kubelet.go:196] the value of KubeletConfiguration.cgroupDriver is empty; setting it to "systemd"
I0520 17:59:23.007840    7898 version.go:187] fetching Kubernetes version from URL: https://dl.k8s.io/release/stable-1.txt
W0520 17:59:33.011810    7898 version.go:104] could not fetch a Kubernetes version from the internet: unable to get URL "https://dl.k8s.io/release/stable-1.txt": Get "https://dl.k8s.io/release/stable-1.txt": context deadline exceeded (Client.Timeout exceeded while awaiting headers)
W0520 17:59:33.011887    7898 version.go:105] falling back to the local client version: v1.30.1
I0520 17:59:33.012883    7898 certs.go:483] validating certificate period for CA certificate
I0520 17:59:33.013149    7898 certs.go:483] validating certificate period for front-proxy CA certificate
[init] Using Kubernetes version: v1.30.1
[preflight] Running pre-flight checks
I0520 17:59:33.013887    7898 checks.go:561] validating Kubernetes and kubeadm version
I0520 17:59:33.013957    7898 checks.go:166] validating if the firewall is enabled and active
I0520 17:59:33.084140    7898 checks.go:201] validating availability of port 6443
I0520 17:59:33.084990    7898 checks.go:201] validating availability of port 10259
I0520 17:59:33.085263    7898 checks.go:201] validating availability of port 10257
I0520 17:59:33.085700    7898 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-apiserver.yaml
I0520 17:59:33.085951    7898 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-controller-manager.yaml
I0520 17:59:33.086036    7898 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-scheduler.yaml
I0520 17:59:33.086115    7898 checks.go:278] validating the existence of file /etc/kubernetes/manifests/etcd.yaml
I0520 17:59:33.086193    7898 checks.go:428] validating if the connectivity type is via proxy or direct
I0520 17:59:33.086289    7898 checks.go:467] validating http connectivity to first IP address in the CIDR
I0520 17:59:33.086356    7898 checks.go:467] validating http connectivity to first IP address in the CIDR
I0520 17:59:33.086597    7898 checks.go:102] validating the container runtime
I0520 17:59:33.210527    7898 checks.go:637] validating whether swap is enabled or not
I0520 17:59:33.210688    7898 checks.go:368] validating the presence of executable crictl
I0520 17:59:33.210760    7898 checks.go:368] validating the presence of executable conntrack
I0520 17:59:33.210804    7898 checks.go:368] validating the presence of executable ip
I0520 17:59:33.210851    7898 checks.go:368] validating the presence of executable iptables
I0520 17:59:33.210898    7898 checks.go:368] validating the presence of executable mount
I0520 17:59:33.210943    7898 checks.go:368] validating the presence of executable nsenter
I0520 17:59:33.210987    7898 checks.go:368] validating the presence of executable ebtables
I0520 17:59:33.211040    7898 checks.go:368] validating the presence of executable ethtool
I0520 17:59:33.211096    7898 checks.go:368] validating the presence of executable socat
I0520 17:59:33.211163    7898 checks.go:368] validating the presence of executable tc
I0520 17:59:33.211234    7898 checks.go:368] validating the presence of executable touch
I0520 17:59:33.211283    7898 checks.go:514] running all checks
I0520 17:59:33.259114    7898 checks.go:399] checking whether the given node name is valid and reachable using net.LookupHost
I0520 17:59:33.259216    7898 checks.go:603] validating kubelet version
I0520 17:59:33.440754    7898 checks.go:128] validating if the "kubelet" service is enabled and active
I0520 17:59:33.497596    7898 checks.go:201] validating availability of port 10250
I0520 17:59:33.498072    7898 checks.go:327] validating the contents of file /proc/sys/net/ipv4/ip_forward
I0520 17:59:33.498203    7898 checks.go:201] validating availability of port 2379
I0520 17:59:33.498342    7898 checks.go:201] validating availability of port 2380
I0520 17:59:33.498837    7898 checks.go:241] validating the existence and emptiness of directory /var/lib/etcd
[preflight] Some fatal errors occurred:
	[ERROR Port-6443]: Port 6443 is in use
	[ERROR Port-10259]: Port 10259 is in use
	[ERROR Port-10257]: Port 10257 is in use
	[ERROR FileAvailable--etc-kubernetes-manifests-kube-apiserver.yaml]: /etc/kubernetes/manifests/kube-apiserver.yaml already exists
	[ERROR FileAvailable--etc-kubernetes-manifests-kube-controller-manager.yaml]: /etc/kubernetes/manifests/kube-controller-manager.yaml already exists
	[ERROR FileAvailable--etc-kubernetes-manifests-kube-scheduler.yaml]: /etc/kubernetes/manifests/kube-scheduler.yaml already exists
	[ERROR FileAvailable--etc-kubernetes-manifests-etcd.yaml]: /etc/kubernetes/manifests/etcd.yaml already exists
	[ERROR Port-10250]: Port 10250 is in use
	[ERROR Port-2379]: Port 2379 is in use
	[ERROR Port-2380]: Port 2380 is in use
	[ERROR DirAvailable--var-lib-etcd]: /var/lib/etcd is not empty
[preflight] If you know what you are doing, you can make a check non-fatal with `--ignore-preflight-errors=...`
error execution phase preflight
k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow.(*Runner).Run.func1
	k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow/runner.go:260
k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow.(*Runner).visitAll
	k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow/runner.go:446
k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow.(*Runner).Run
	k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow/runner.go:232
k8s.io/kubernetes/cmd/kubeadm/app/cmd.newCmdInit.func1
	k8s.io/kubernetes/cmd/kubeadm/app/cmd/init.go:128
github.com/spf13/cobra.(*Command).execute
	github.com/spf13/cobra@v1.7.0/command.go:940
github.com/spf13/cobra.(*Command).ExecuteC
	github.com/spf13/cobra@v1.7.0/command.go:1068
github.com/spf13/cobra.(*Command).Execute
	github.com/spf13/cobra@v1.7.0/command.go:992
k8s.io/kubernetes/cmd/kubeadm/app.Run
	k8s.io/kubernetes/cmd/kubeadm/app/kubeadm.go:52
main.main
	k8s.io/kubernetes/cmd/kubeadm/kubeadm.go:25
runtime.main
	runtime/proc.go:271
runtime.goexit
	runtime/asm_amd64.s:1695
master@master:~$ sudo kubeadm init --cri-socket unix:///var/run/containerd/containerd.sock --v=5 --pod-network-cidr=10.244.0.0/16
I0520 17:59:56.997634    7931 interface.go:432] Looking for default routes with IPv4 addresses
I0520 17:59:56.997682    7931 interface.go:437] Default route transits interface "ens33"
I0520 17:59:56.997854    7931 interface.go:209] Interface ens33 is up
I0520 17:59:56.997922    7931 interface.go:257] Interface "ens33" has 2 addresses :[192.168.0.193/24 fe80::20c:29ff:fe09:602d/64].
I0520 17:59:56.997936    7931 interface.go:224] Checking addr  192.168.0.193/24.
I0520 17:59:56.997946    7931 interface.go:231] IP found 192.168.0.193
I0520 17:59:56.997968    7931 interface.go:263] Found valid IPv4 address 192.168.0.193 for interface "ens33".
I0520 17:59:56.997977    7931 interface.go:443] Found active IP 192.168.0.193 
I0520 17:59:56.997995    7931 kubelet.go:196] the value of KubeletConfiguration.cgroupDriver is empty; setting it to "systemd"
I0520 17:59:57.006432    7931 version.go:187] fetching Kubernetes version from URL: https://dl.k8s.io/release/stable-1.txt
I0520 17:59:57.814715    7931 certs.go:483] validating certificate period for CA certificate
I0520 17:59:57.814948    7931 certs.go:483] validating certificate period for front-proxy CA certificate
[init] Using Kubernetes version: v1.30.1
[preflight] Running pre-flight checks
I0520 17:59:57.815929    7931 checks.go:561] validating Kubernetes and kubeadm version
I0520 17:59:57.816002    7931 checks.go:166] validating if the firewall is enabled and active
I0520 17:59:57.863854    7931 checks.go:201] validating availability of port 6443
I0520 17:59:57.864143    7931 checks.go:201] validating availability of port 10259
I0520 17:59:57.864207    7931 checks.go:201] validating availability of port 10257
I0520 17:59:57.864249    7931 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-apiserver.yaml
I0520 17:59:57.864321    7931 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-controller-manager.yaml
I0520 17:59:57.864356    7931 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-scheduler.yaml
I0520 17:59:57.864378    7931 checks.go:278] validating the existence of file /etc/kubernetes/manifests/etcd.yaml
I0520 17:59:57.864461    7931 checks.go:428] validating if the connectivity type is via proxy or direct
I0520 17:59:57.864505    7931 checks.go:467] validating http connectivity to first IP address in the CIDR
I0520 17:59:57.864553    7931 checks.go:467] validating http connectivity to first IP address in the CIDR
I0520 17:59:57.864575    7931 checks.go:102] validating the container runtime
I0520 17:59:57.898418    7931 checks.go:637] validating whether swap is enabled or not
I0520 17:59:57.898519    7931 checks.go:368] validating the presence of executable crictl
I0520 17:59:57.898557    7931 checks.go:368] validating the presence of executable conntrack
I0520 17:59:57.898579    7931 checks.go:368] validating the presence of executable ip
I0520 17:59:57.898602    7931 checks.go:368] validating the presence of executable iptables
I0520 17:59:57.898621    7931 checks.go:368] validating the presence of executable mount
I0520 17:59:57.898637    7931 checks.go:368] validating the presence of executable nsenter
I0520 17:59:57.898651    7931 checks.go:368] validating the presence of executable ebtables
I0520 17:59:57.898667    7931 checks.go:368] validating the presence of executable ethtool
I0520 17:59:57.898679    7931 checks.go:368] validating the presence of executable socat
I0520 17:59:57.898693    7931 checks.go:368] validating the presence of executable tc
I0520 17:59:57.898706    7931 checks.go:368] validating the presence of executable touch
I0520 17:59:57.898731    7931 checks.go:514] running all checks
I0520 17:59:57.915306    7931 checks.go:399] checking whether the given node name is valid and reachable using net.LookupHost
I0520 17:59:57.915334    7931 checks.go:603] validating kubelet version
I0520 17:59:57.967793    7931 checks.go:128] validating if the "kubelet" service is enabled and active
I0520 17:59:57.986746    7931 checks.go:201] validating availability of port 10250
I0520 17:59:57.986897    7931 checks.go:327] validating the contents of file /proc/sys/net/ipv4/ip_forward
I0520 17:59:57.987030    7931 checks.go:201] validating availability of port 2379
I0520 17:59:57.987101    7931 checks.go:201] validating availability of port 2380
I0520 17:59:57.987146    7931 checks.go:241] validating the existence and emptiness of directory /var/lib/etcd
[preflight] Some fatal errors occurred:
	[ERROR Port-6443]: Port 6443 is in use
	[ERROR Port-10259]: Port 10259 is in use
	[ERROR Port-10257]: Port 10257 is in use
	[ERROR FileAvailable--etc-kubernetes-manifests-kube-apiserver.yaml]: /etc/kubernetes/manifests/kube-apiserver.yaml already exists
	[ERROR FileAvailable--etc-kubernetes-manifests-kube-controller-manager.yaml]: /etc/kubernetes/manifests/kube-controller-manager.yaml already exists
	[ERROR FileAvailable--etc-kubernetes-manifests-kube-scheduler.yaml]: /etc/kubernetes/manifests/kube-scheduler.yaml already exists
	[ERROR FileAvailable--etc-kubernetes-manifests-etcd.yaml]: /etc/kubernetes/manifests/etcd.yaml already exists
	[ERROR Port-10250]: Port 10250 is in use
	[ERROR Port-2379]: Port 2379 is in use
	[ERROR Port-2380]: Port 2380 is in use
	[ERROR DirAvailable--var-lib-etcd]: /var/lib/etcd is not empty
[preflight] If you know what you are doing, you can make a check non-fatal with `--ignore-preflight-errors=...`
error execution phase preflight
k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow.(*Runner).Run.func1
	k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow/runner.go:260
k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow.(*Runner).visitAll
	k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow/runner.go:446
k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow.(*Runner).Run
	k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow/runner.go:232
k8s.io/kubernetes/cmd/kubeadm/app/cmd.newCmdInit.func1
	k8s.io/kubernetes/cmd/kubeadm/app/cmd/init.go:128
github.com/spf13/cobra.(*Command).execute
	github.com/spf13/cobra@v1.7.0/command.go:940
github.com/spf13/cobra.(*Command).ExecuteC
	github.com/spf13/cobra@v1.7.0/command.go:1068
github.com/spf13/cobra.(*Command).Execute
	github.com/spf13/cobra@v1.7.0/command.go:992
k8s.io/kubernetes/cmd/kubeadm/app.Run
	k8s.io/kubernetes/cmd/kubeadm/app/kubeadm.go:52
main.main
	k8s.io/kubernetes/cmd/kubeadm/kubeadm.go:25
runtime.main
	runtime/proc.go:271
runtime.goexit
	runtime/asm_amd64.s:1695
master@master:~$ sudo systemctl restart kubelet
master@master:~$ sudo systemctl restart kubectl
Failed to restart kubectl.service: Unit kubectl.service not found.
master@master:~$ sudo systemctl restart kube-apiserver
Failed to restart kube-apiserver.service: Unit kube-apiserver.service not found.
master@master:~$ kubectl get pods -n kube-system | grep kube-apiserver
error: error loading config file "/etc/kubernetes/admin.conf": open /etc/kubernetes/admin.conf: permission denied
master@master:~$ sudo kubectl get pods -n kube-system | grep kube-apiserver
E0520 18:01:46.910454    8023 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:01:46.911073    8023 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:01:46.912013    8023 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:01:46.913526    8023 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:01:46.913725    8023 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
The connection to the server localhost:8080 was refused - did you specify the right host or port?
master@master:~$ sudo systemctl status kubelet
● kubelet.service - kubelet: The Kubernetes Node Agent
     Loaded: loaded (/usr/lib/systemd/system/kubelet.service; enabled; preset: enabled)
    Drop-In: /usr/lib/systemd/system/kubelet.service.d
             └─10-kubeadm.conf
     Active: active (running) since Mon 2024-05-20 18:00:55 UTC; 1min 18s ago
       Docs: https://kubernetes.io/docs/
   Main PID: 7970 (kubelet)
      Tasks: 13 (limit: 9388)
     Memory: 30.1M (peak: 31.1M)
        CPU: 8.890s
     CGroup: /system.slice/kubelet.service
             └─7970 /usr/bin/kubelet --bootstrap-kubeconfig=/etc/kubernetes/bootstrap-kubelet.conf --kubeconfig=/etc/kubernetes/kubelet.conf --config=/var/lib/kubelet/config.yaml --container-runtime-endpoint=unix:///var/run/containerd/containerd.sock --pod-infra-container-image=registry.k8s.io/pause:3.9

May 20 18:00:55 master kubelet[7970]: I0520 18:00:55.776235    7970 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"k8s-certs\" (UniqueName: \"kubernetes.io/host-path/3efa7997bb3dcba687eb8ddec37317d4-k8s-certs\") pod \"kube-apiserver-master\" (UID: \"3efa7997bb3dcba687eb8ddec37317d4\") " pod="kube-system/kube-apiserver-master"
May 20 18:00:55 master kubelet[7970]: I0520 18:00:55.776252    7970 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"usr-share-ca-certificates\" (UniqueName: \"kubernetes.io/host-path/3efa7997bb3dcba687eb8ddec37317d4-usr-share-ca-certificates\") pod \"kube-apiserver-master\" (UID: \"3efa7997bb3dcba687eb8ddec37317d4\") " pod="kube-system/kube-apiserver-master"
May 20 18:00:55 master kubelet[7970]: I0520 18:00:55.776270    7970 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"usr-local-share-ca-certificates\" (UniqueName: \"kubernetes.io/host-path/4323188f28e6dc6f27657dca98efeda7-usr-local-share-ca-certificates\") pod \"kube-controller-manager-master\" (UID: \"4323188f28e6dc6f27657dca98efeda7\") " pod="kube-system/kube-controller-manager-master"
May 20 18:00:55 master kubelet[7970]: I0520 18:00:55.776288    7970 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"usr-share-ca-certificates\" (UniqueName: \"kubernetes.io/host-path/4323188f28e6dc6f27657dca98efeda7-usr-share-ca-certificates\") pod \"kube-controller-manager-master\" (UID: \"4323188f28e6dc6f27657dca98efeda7\") " pod="kube-system/kube-controller-manager-master"
May 20 18:00:56 master kubelet[7970]: I0520 18:00:56.547147    7970 apiserver.go:52] "Watching apiserver"
May 20 18:00:56 master kubelet[7970]: I0520 18:00:56.558082    7970 topology_manager.go:215] "Topology Admit Handler" podUID="cb84359a-3688-47ba-a7ab-8b296dfed7a7" podNamespace="kube-system" podName="kube-proxy-fvpvt"
May 20 18:00:56 master kubelet[7970]: I0520 18:00:56.567945    7970 desired_state_of_world_populator.go:157] "Finished populating initial desired state of world"
May 20 18:00:56 master kubelet[7970]: I0520 18:00:56.584226    7970 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"xtables-lock\" (UniqueName: \"kubernetes.io/host-path/cb84359a-3688-47ba-a7ab-8b296dfed7a7-xtables-lock\") pod \"kube-proxy-fvpvt\" (UID: \"cb84359a-3688-47ba-a7ab-8b296dfed7a7\") " pod="kube-system/kube-proxy-fvpvt"
May 20 18:00:56 master kubelet[7970]: I0520 18:00:56.584557    7970 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"lib-modules\" (UniqueName: \"kubernetes.io/host-path/cb84359a-3688-47ba-a7ab-8b296dfed7a7-lib-modules\") pod \"kube-proxy-fvpvt\" (UID: \"cb84359a-3688-47ba-a7ab-8b296dfed7a7\") " pod="kube-system/kube-proxy-fvpvt"
May 20 18:00:56 master kubelet[7970]: E0520 18:00:56.621833    7970 kubelet.go:1928] "Failed creating a mirror pod for" err="pods \"kube-apiserver-master\" already exists" pod="kube-system/kube-apiserver-master"
master@master:~$ sudo lsof -i :6443
sudo lsof -i :10259
sudo lsof -i :10257
sudo lsof -i :10250
sudo lsof -i :2379
sudo lsof -i :2380
sudo: lsof: command not found
sudo: lsof: command not found
sudo: lsof: command not found
sudo: lsof: command not found
sudo: lsof: command not found
sudo: lsof: command not found
master@master:~$ sudo rm -rf /var/lib/etcd/*
master@master:~$ sudo apt-get install lsof
Reading package lists... Done
Building dependency tree... Done
Reading state information... Done
The following NEW packages will be installed:
  lsof
0 upgraded, 1 newly installed, 0 to remove and 4 not upgraded.
Need to get 247 kB of archives.
After this operation, 486 kB of additional disk space will be used.
Get:1 http://bd.archive.ubuntu.com/ubuntu noble/main amd64 lsof amd64 4.95.0-1build3 [247 kB]
Fetched 247 kB in 2s (132 kB/s)
debconf: delaying package configuration, since apt-utils is not installed
Selecting previously unselected package lsof.
(Reading database ... 77969 files and directories currently installed.)
Preparing to unpack .../lsof_4.95.0-1build3_amd64.deb ...
Unpacking lsof (4.95.0-1build3) ...
Setting up lsof (4.95.0-1build3) ...
Scanning processes...                                                                                                                                                                    
Scanning linux images...                                                                                                                                                                 

Running kernel seems to be up-to-date.

No services need to be restarted.

No containers need to be restarted.

No user sessions are running outdated binaries.

No VM guests are running outdated hypervisor (qemu) binaries on this host.
master@master:~$ sudo lsof -i :6443
COMMAND    PID USER   FD   TYPE DEVICE SIZE/OFF NODE NAME
kube-apis 6801 root    3u  IPv6  40525      0t0  TCP *:6443 (LISTEN)
kube-apis 6801 root   69u  IPv6  41995      0t0  TCP master:6443->master:39870 (ESTABLISHED)
kube-apis 6801 root   70u  IPv6  39910      0t0  TCP master:6443->master:54228 (ESTABLISHED)
kube-apis 6801 root   71u  IPv6  67087      0t0  TCP master:6443->master:44656 (ESTABLISHED)
kube-apis 6801 root   72u  IPv6  42143      0t0  TCP master:6443->master:54232 (ESTABLISHED)
kube-apis 6801 root   73u  IPv6  41148      0t0  TCP master:6443->master:39846 (ESTABLISHED)
kube-apis 6801 root   74u  IPv6  41149      0t0  TCP master:6443->master:39854 (ESTABLISHED)
kube-apis 6801 root   76u  IPv6  40600      0t0  TCP ip6-localhost:35990->ip6-localhost:6443 (ESTABLISHED)
kube-apis 6801 root   78u  IPv6  40601      0t0  TCP ip6-localhost:6443->ip6-localhost:35990 (ESTABLISHED)
kube-sche 6803 root    7u  IPv4  41111      0t0  TCP master:39854->master:6443 (ESTABLISHED)
kube-sche 6803 root    8u  IPv4  39756      0t0  TCP master:39870->master:6443 (ESTABLISHED)
kube-cont 6818 root    9u  IPv4  38887      0t0  TCP master:39846->master:6443 (ESTABLISHED)
kube-cont 6818 root   10u  IPv4  41340      0t0  TCP master:54228->master:6443 (ESTABLISHED)
kube-prox 7019 root    7u  IPv4  41433      0t0  TCP master:54232->master:6443 (ESTABLISHED)
kubelet   7970 root   11u  IPv4  68640      0t0  TCP master:44656->master:6443 (ESTABLISHED)
master@master:~$ sudo kubeadm init --cri-socket unix:///var/run/containerd/containerd.sock --v=5 --pod-network-cidr=10.244.0.0/16
I0520 18:04:25.988692    8122 interface.go:432] Looking for default routes with IPv4 addresses
I0520 18:04:25.988754    8122 interface.go:437] Default route transits interface "ens33"
I0520 18:04:25.989060    8122 interface.go:209] Interface ens33 is up
I0520 18:04:25.989156    8122 interface.go:257] Interface "ens33" has 2 addresses :[192.168.0.193/24 fe80::20c:29ff:fe09:602d/64].
I0520 18:04:25.989372    8122 interface.go:224] Checking addr  192.168.0.193/24.
I0520 18:04:25.989416    8122 interface.go:231] IP found 192.168.0.193
I0520 18:04:25.989433    8122 interface.go:263] Found valid IPv4 address 192.168.0.193 for interface "ens33".
I0520 18:04:25.989452    8122 interface.go:443] Found active IP 192.168.0.193 
I0520 18:04:25.989526    8122 kubelet.go:196] the value of KubeletConfiguration.cgroupDriver is empty; setting it to "systemd"
I0520 18:04:25.996578    8122 version.go:187] fetching Kubernetes version from URL: https://dl.k8s.io/release/stable-1.txt
I0520 18:04:26.819714    8122 certs.go:483] validating certificate period for CA certificate
I0520 18:04:26.820116    8122 certs.go:483] validating certificate period for front-proxy CA certificate
[init] Using Kubernetes version: v1.30.1
[preflight] Running pre-flight checks
I0520 18:04:26.821522    8122 checks.go:561] validating Kubernetes and kubeadm version
I0520 18:04:26.821625    8122 checks.go:166] validating if the firewall is enabled and active
I0520 18:04:26.855891    8122 checks.go:201] validating availability of port 6443
I0520 18:04:26.856253    8122 checks.go:201] validating availability of port 10259
I0520 18:04:26.856476    8122 checks.go:201] validating availability of port 10257
I0520 18:04:26.856559    8122 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-apiserver.yaml
I0520 18:04:26.856583    8122 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-controller-manager.yaml
I0520 18:04:26.856601    8122 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-scheduler.yaml
I0520 18:04:26.856615    8122 checks.go:278] validating the existence of file /etc/kubernetes/manifests/etcd.yaml
I0520 18:04:26.856630    8122 checks.go:428] validating if the connectivity type is via proxy or direct
I0520 18:04:26.856649    8122 checks.go:467] validating http connectivity to first IP address in the CIDR
I0520 18:04:26.856665    8122 checks.go:467] validating http connectivity to first IP address in the CIDR
I0520 18:04:26.856675    8122 checks.go:102] validating the container runtime
I0520 18:04:26.886592    8122 checks.go:637] validating whether swap is enabled or not
I0520 18:04:26.886711    8122 checks.go:368] validating the presence of executable crictl
I0520 18:04:26.886778    8122 checks.go:368] validating the presence of executable conntrack
I0520 18:04:26.886803    8122 checks.go:368] validating the presence of executable ip
I0520 18:04:26.886851    8122 checks.go:368] validating the presence of executable iptables
I0520 18:04:26.886873    8122 checks.go:368] validating the presence of executable mount
I0520 18:04:26.886895    8122 checks.go:368] validating the presence of executable nsenter
I0520 18:04:26.886947    8122 checks.go:368] validating the presence of executable ebtables
I0520 18:04:26.886995    8122 checks.go:368] validating the presence of executable ethtool
I0520 18:04:26.887057    8122 checks.go:368] validating the presence of executable socat
I0520 18:04:26.887110    8122 checks.go:368] validating the presence of executable tc
I0520 18:04:26.887149    8122 checks.go:368] validating the presence of executable touch
I0520 18:04:26.887243    8122 checks.go:514] running all checks
I0520 18:04:26.901666    8122 checks.go:399] checking whether the given node name is valid and reachable using net.LookupHost
I0520 18:04:26.901719    8122 checks.go:603] validating kubelet version
I0520 18:04:26.956451    8122 checks.go:128] validating if the "kubelet" service is enabled and active
I0520 18:04:26.974413    8122 checks.go:201] validating availability of port 10250
I0520 18:04:26.974534    8122 checks.go:327] validating the contents of file /proc/sys/net/ipv4/ip_forward
I0520 18:04:26.974710    8122 checks.go:201] validating availability of port 2379
I0520 18:04:26.974758    8122 checks.go:201] validating availability of port 2380
I0520 18:04:26.974788    8122 checks.go:241] validating the existence and emptiness of directory /var/lib/etcd
[preflight] Some fatal errors occurred:
	[ERROR Port-6443]: Port 6443 is in use
	[ERROR Port-10259]: Port 10259 is in use
	[ERROR Port-10257]: Port 10257 is in use
	[ERROR FileAvailable--etc-kubernetes-manifests-kube-apiserver.yaml]: /etc/kubernetes/manifests/kube-apiserver.yaml already exists
	[ERROR FileAvailable--etc-kubernetes-manifests-kube-controller-manager.yaml]: /etc/kubernetes/manifests/kube-controller-manager.yaml already exists
	[ERROR FileAvailable--etc-kubernetes-manifests-kube-scheduler.yaml]: /etc/kubernetes/manifests/kube-scheduler.yaml already exists
	[ERROR FileAvailable--etc-kubernetes-manifests-etcd.yaml]: /etc/kubernetes/manifests/etcd.yaml already exists
	[ERROR Port-10250]: Port 10250 is in use
	[ERROR Port-2379]: Port 2379 is in use
	[ERROR Port-2380]: Port 2380 is in use
	[ERROR DirAvailable--var-lib-etcd]: /var/lib/etcd is not empty
[preflight] If you know what you are doing, you can make a check non-fatal with `--ignore-preflight-errors=...`
error execution phase preflight
k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow.(*Runner).Run.func1
	k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow/runner.go:260
k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow.(*Runner).visitAll
	k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow/runner.go:446
k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow.(*Runner).Run
	k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow/runner.go:232
k8s.io/kubernetes/cmd/kubeadm/app/cmd.newCmdInit.func1
	k8s.io/kubernetes/cmd/kubeadm/app/cmd/init.go:128
github.com/spf13/cobra.(*Command).execute
	github.com/spf13/cobra@v1.7.0/command.go:940
github.com/spf13/cobra.(*Command).ExecuteC
	github.com/spf13/cobra@v1.7.0/command.go:1068
github.com/spf13/cobra.(*Command).Execute
	github.com/spf13/cobra@v1.7.0/command.go:992
k8s.io/kubernetes/cmd/kubeadm/app.Run
	k8s.io/kubernetes/cmd/kubeadm/app/kubeadm.go:52
main.main
	k8s.io/kubernetes/cmd/kubeadm/kubeadm.go:25
runtime.main
	runtime/proc.go:271
runtime.goexit
	runtime/asm_amd64.s:1695
master@master:~$ sudo lsof -i 6443
lsof: unknown protocol name (443) in: -i 6443
lsof 4.95.0
 latest revision: https://github.com/lsof-org/lsof
 latest FAQ: https://github.com/lsof-org/lsof/blob/master/00FAQ
 latest (non-formatted) man page: https://github.com/lsof-org/lsof/blob/master/Lsof.8
 usage: [-?abhKlnNoOPRtUvVX] [+|-c c] [+|-d s] [+D D] [+|-E] [+|-e s] [+|-f[gG]]
 [-F [f]] [-g [s]] [-i [i]] [+|-L [l]] [+m [m]] [+|-M] [-o [o]] [-p s]
 [+|-r [t]] [-s [p:s]] [-S [t]] [-T [t]] [-u s] [+|-w] [-x [fl]] [--] [names]
Use the ``-h'' option to get more help information.
master@master:~$ sudo lsof -i :6443
COMMAND    PID USER   FD   TYPE DEVICE SIZE/OFF NODE NAME
kube-apis 6801 root    3u  IPv6  40525      0t0  TCP *:6443 (LISTEN)
kube-apis 6801 root   69u  IPv6  41995      0t0  TCP master:6443->master:39870 (ESTABLISHED)
kube-apis 6801 root   70u  IPv6  39910      0t0  TCP master:6443->master:54228 (ESTABLISHED)
kube-apis 6801 root   71u  IPv6  67087      0t0  TCP master:6443->master:44656 (ESTABLISHED)
kube-apis 6801 root   72u  IPv6  42143      0t0  TCP master:6443->master:54232 (ESTABLISHED)
kube-apis 6801 root   73u  IPv6  41148      0t0  TCP master:6443->master:39846 (ESTABLISHED)
kube-apis 6801 root   74u  IPv6  41149      0t0  TCP master:6443->master:39854 (ESTABLISHED)
kube-apis 6801 root   76u  IPv6  40600      0t0  TCP ip6-localhost:35990->ip6-localhost:6443 (ESTABLISHED)
kube-apis 6801 root   78u  IPv6  40601      0t0  TCP ip6-localhost:6443->ip6-localhost:35990 (ESTABLISHED)
kube-sche 6803 root    7u  IPv4  41111      0t0  TCP master:39854->master:6443 (ESTABLISHED)
kube-sche 6803 root    8u  IPv4  39756      0t0  TCP master:39870->master:6443 (ESTABLISHED)
kube-cont 6818 root    9u  IPv4  38887      0t0  TCP master:39846->master:6443 (ESTABLISHED)
kube-cont 6818 root   10u  IPv4  41340      0t0  TCP master:54228->master:6443 (ESTABLISHED)
kube-prox 7019 root    7u  IPv4  41433      0t0  TCP master:54232->master:6443 (ESTABLISHED)
kubelet   7970 root   11u  IPv4  68640      0t0  TCP master:44656->master:6443 (ESTABLISHED)
master@master:~$ sudo kill 6801
master@master:~$ sudo kill -9 6801
master@master:~$ sudo kubeadm init --cri-socket unix:///var/run/containerd/containerd.sock --v=5 --pod-network-cidr=10.244.0.0/16
I0520 18:05:39.017317    8366 interface.go:432] Looking for default routes with IPv4 addresses
I0520 18:05:39.017351    8366 interface.go:437] Default route transits interface "ens33"
I0520 18:05:39.017560    8366 interface.go:209] Interface ens33 is up
I0520 18:05:39.017636    8366 interface.go:257] Interface "ens33" has 2 addresses :[192.168.0.193/24 fe80::20c:29ff:fe09:602d/64].
I0520 18:05:39.017647    8366 interface.go:224] Checking addr  192.168.0.193/24.
I0520 18:05:39.017654    8366 interface.go:231] IP found 192.168.0.193
I0520 18:05:39.017669    8366 interface.go:263] Found valid IPv4 address 192.168.0.193 for interface "ens33".
I0520 18:05:39.017675    8366 interface.go:443] Found active IP 192.168.0.193 
I0520 18:05:39.017689    8366 kubelet.go:196] the value of KubeletConfiguration.cgroupDriver is empty; setting it to "systemd"
I0520 18:05:39.026604    8366 version.go:187] fetching Kubernetes version from URL: https://dl.k8s.io/release/stable-1.txt
I0520 18:05:40.909703    8366 certs.go:483] validating certificate period for CA certificate
I0520 18:05:40.910013    8366 certs.go:483] validating certificate period for front-proxy CA certificate
[init] Using Kubernetes version: v1.30.1
[preflight] Running pre-flight checks
I0520 18:05:40.913154    8366 checks.go:561] validating Kubernetes and kubeadm version
I0520 18:05:40.913256    8366 checks.go:166] validating if the firewall is enabled and active
I0520 18:05:40.953991    8366 checks.go:201] validating availability of port 6443
I0520 18:05:40.954332    8366 checks.go:201] validating availability of port 10259
I0520 18:05:40.954445    8366 checks.go:201] validating availability of port 10257
I0520 18:05:40.954501    8366 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-apiserver.yaml
I0520 18:05:40.954577    8366 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-controller-manager.yaml
I0520 18:05:40.954612    8366 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-scheduler.yaml
I0520 18:05:40.954638    8366 checks.go:278] validating the existence of file /etc/kubernetes/manifests/etcd.yaml
I0520 18:05:40.954662    8366 checks.go:428] validating if the connectivity type is via proxy or direct
I0520 18:05:40.954690    8366 checks.go:467] validating http connectivity to first IP address in the CIDR
I0520 18:05:40.954716    8366 checks.go:467] validating http connectivity to first IP address in the CIDR
I0520 18:05:40.954733    8366 checks.go:102] validating the container runtime
I0520 18:05:40.998354    8366 checks.go:637] validating whether swap is enabled or not
I0520 18:05:40.998497    8366 checks.go:368] validating the presence of executable crictl
I0520 18:05:40.998524    8366 checks.go:368] validating the presence of executable conntrack
I0520 18:05:40.998538    8366 checks.go:368] validating the presence of executable ip
I0520 18:05:40.998553    8366 checks.go:368] validating the presence of executable iptables
I0520 18:05:40.998569    8366 checks.go:368] validating the presence of executable mount
I0520 18:05:40.998583    8366 checks.go:368] validating the presence of executable nsenter
I0520 18:05:40.998597    8366 checks.go:368] validating the presence of executable ebtables
I0520 18:05:40.998611    8366 checks.go:368] validating the presence of executable ethtool
I0520 18:05:40.998622    8366 checks.go:368] validating the presence of executable socat
I0520 18:05:40.998636    8366 checks.go:368] validating the presence of executable tc
I0520 18:05:40.998647    8366 checks.go:368] validating the presence of executable touch
I0520 18:05:40.998664    8366 checks.go:514] running all checks
I0520 18:05:41.015739    8366 checks.go:399] checking whether the given node name is valid and reachable using net.LookupHost
I0520 18:05:41.015776    8366 checks.go:603] validating kubelet version
I0520 18:05:41.073203    8366 checks.go:128] validating if the "kubelet" service is enabled and active
I0520 18:05:41.090765    8366 checks.go:201] validating availability of port 10250
I0520 18:05:41.090889    8366 checks.go:327] validating the contents of file /proc/sys/net/ipv4/ip_forward
I0520 18:05:41.090983    8366 checks.go:201] validating availability of port 2379
I0520 18:05:41.091043    8366 checks.go:201] validating availability of port 2380
I0520 18:05:41.091114    8366 checks.go:241] validating the existence and emptiness of directory /var/lib/etcd
[preflight] Some fatal errors occurred:
	[ERROR Port-6443]: Port 6443 is in use
	[ERROR Port-10259]: Port 10259 is in use
	[ERROR Port-10257]: Port 10257 is in use
	[ERROR FileAvailable--etc-kubernetes-manifests-kube-apiserver.yaml]: /etc/kubernetes/manifests/kube-apiserver.yaml already exists
	[ERROR FileAvailable--etc-kubernetes-manifests-kube-controller-manager.yaml]: /etc/kubernetes/manifests/kube-controller-manager.yaml already exists
	[ERROR FileAvailable--etc-kubernetes-manifests-kube-scheduler.yaml]: /etc/kubernetes/manifests/kube-scheduler.yaml already exists
	[ERROR FileAvailable--etc-kubernetes-manifests-etcd.yaml]: /etc/kubernetes/manifests/etcd.yaml already exists
	[ERROR Port-10250]: Port 10250 is in use
	[ERROR Port-2379]: Port 2379 is in use
	[ERROR Port-2380]: Port 2380 is in use
	[ERROR DirAvailable--var-lib-etcd]: /var/lib/etcd is not empty
[preflight] If you know what you are doing, you can make a check non-fatal with `--ignore-preflight-errors=...`
error execution phase preflight
k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow.(*Runner).Run.func1
	k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow/runner.go:260
k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow.(*Runner).visitAll
	k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow/runner.go:446
k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow.(*Runner).Run
	k8s.io/kubernetes/cmd/kubeadm/app/cmd/phases/workflow/runner.go:232
k8s.io/kubernetes/cmd/kubeadm/app/cmd.newCmdInit.func1
	k8s.io/kubernetes/cmd/kubeadm/app/cmd/init.go:128
github.com/spf13/cobra.(*Command).execute
	github.com/spf13/cobra@v1.7.0/command.go:940
github.com/spf13/cobra.(*Command).ExecuteC
	github.com/spf13/cobra@v1.7.0/command.go:1068
github.com/spf13/cobra.(*Command).Execute
	github.com/spf13/cobra@v1.7.0/command.go:992
k8s.io/kubernetes/cmd/kubeadm/app.Run
	k8s.io/kubernetes/cmd/kubeadm/app/kubeadm.go:52
main.main
	k8s.io/kubernetes/cmd/kubeadm/kubeadm.go:25
runtime.main
	runtime/proc.go:271
runtime.goexit
	runtime/asm_amd64.s:1695
master@master:~$ sudo systemctl stop kubelet
master@master:~$ sudo kubeadm reset -f
[reset] Reading configuration from the cluster...
[reset] FYI: You can look at this config file with 'kubectl -n kube-system get cm kubeadm-config -o yaml'
[preflight] Running pre-flight checks
[reset] Deleted contents of the etcd data directory: /var/lib/etcd
[reset] Stopping the kubelet service
[reset] Unmounting mounted directories in "/var/lib/kubelet"
[reset] Deleting contents of directories: [/etc/kubernetes/manifests /var/lib/kubelet /etc/kubernetes/pki]
[reset] Deleting files: [/etc/kubernetes/admin.conf /etc/kubernetes/super-admin.conf /etc/kubernetes/kubelet.conf /etc/kubernetes/bootstrap-kubelet.conf /etc/kubernetes/controller-manager.conf /etc/kubernetes/scheduler.conf]

The reset process does not clean CNI configuration. To do so, you must remove /etc/cni/net.d

The reset process does not reset or clean up iptables rules or IPVS tables.
If you wish to reset iptables, you must do so manually by using the "iptables" command.

If your cluster was setup to utilize IPVS, run ipvsadm --clear (or similar)
to reset your system's IPVS tables.

The reset process does not clean your kubeconfig files and you must remove them manually.
Please, check the contents of the $HOME/.kube/config file.
master@master:~$ sudo rm -rf /etc/kubernetes/manifests/*
sudo rm -rf /var/lib/etcd
master@master:~$ sudo kubeadm init --cri-socket unix:///var/run/containerd/containerd.sock --v=5 --pod-network-cidr=192.168.0.0/16
I0520 18:07:59.095693    8809 interface.go:432] Looking for default routes with IPv4 addresses
I0520 18:07:59.095987    8809 interface.go:437] Default route transits interface "ens33"
I0520 18:07:59.096393    8809 interface.go:209] Interface ens33 is up
I0520 18:07:59.096584    8809 interface.go:257] Interface "ens33" has 2 addresses :[192.168.0.193/24 fe80::20c:29ff:fe09:602d/64].
I0520 18:07:59.096674    8809 interface.go:224] Checking addr  192.168.0.193/24.
I0520 18:07:59.096787    8809 interface.go:231] IP found 192.168.0.193
I0520 18:07:59.096886    8809 interface.go:263] Found valid IPv4 address 192.168.0.193 for interface "ens33".
I0520 18:07:59.096973    8809 interface.go:443] Found active IP 192.168.0.193 
I0520 18:07:59.097075    8809 kubelet.go:196] the value of KubeletConfiguration.cgroupDriver is empty; setting it to "systemd"
I0520 18:07:59.103507    8809 version.go:187] fetching Kubernetes version from URL: https://dl.k8s.io/release/stable-1.txt
[init] Using Kubernetes version: v1.30.1
[preflight] Running pre-flight checks
I0520 18:07:59.927653    8809 checks.go:561] validating Kubernetes and kubeadm version
I0520 18:07:59.927966    8809 checks.go:166] validating if the firewall is enabled and active
I0520 18:07:59.971059    8809 checks.go:201] validating availability of port 6443
I0520 18:07:59.971304    8809 checks.go:201] validating availability of port 10259
I0520 18:07:59.971349    8809 checks.go:201] validating availability of port 10257
I0520 18:07:59.971431    8809 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-apiserver.yaml
I0520 18:07:59.971450    8809 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-controller-manager.yaml
I0520 18:07:59.971463    8809 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-scheduler.yaml
I0520 18:07:59.971475    8809 checks.go:278] validating the existence of file /etc/kubernetes/manifests/etcd.yaml
I0520 18:07:59.971485    8809 checks.go:428] validating if the connectivity type is via proxy or direct
I0520 18:07:59.971505    8809 checks.go:467] validating http connectivity to first IP address in the CIDR
I0520 18:07:59.971523    8809 checks.go:467] validating http connectivity to first IP address in the CIDR
I0520 18:07:59.971534    8809 checks.go:102] validating the container runtime
I0520 18:07:59.999861    8809 checks.go:637] validating whether swap is enabled or not
I0520 18:07:59.999939    8809 checks.go:368] validating the presence of executable crictl
I0520 18:08:00.000015    8809 checks.go:368] validating the presence of executable conntrack
I0520 18:08:00.000034    8809 checks.go:368] validating the presence of executable ip
I0520 18:08:00.000054    8809 checks.go:368] validating the presence of executable iptables
I0520 18:08:00.000119    8809 checks.go:368] validating the presence of executable mount
I0520 18:08:00.000213    8809 checks.go:368] validating the presence of executable nsenter
I0520 18:08:00.000484    8809 checks.go:368] validating the presence of executable ebtables
I0520 18:08:00.000568    8809 checks.go:368] validating the presence of executable ethtool
I0520 18:08:00.000732    8809 checks.go:368] validating the presence of executable socat
I0520 18:08:00.000783    8809 checks.go:368] validating the presence of executable tc
I0520 18:08:00.000846    8809 checks.go:368] validating the presence of executable touch
I0520 18:08:00.001085    8809 checks.go:514] running all checks
I0520 18:08:00.016548    8809 checks.go:399] checking whether the given node name is valid and reachable using net.LookupHost
I0520 18:08:00.016576    8809 checks.go:603] validating kubelet version
I0520 18:08:00.075481    8809 checks.go:128] validating if the "kubelet" service is enabled and active
I0520 18:08:00.092229    8809 checks.go:201] validating availability of port 10250
I0520 18:08:00.092303    8809 checks.go:327] validating the contents of file /proc/sys/net/ipv4/ip_forward
I0520 18:08:00.092370    8809 checks.go:201] validating availability of port 2379
I0520 18:08:00.092432    8809 checks.go:201] validating availability of port 2380
I0520 18:08:00.092479    8809 checks.go:241] validating the existence and emptiness of directory /var/lib/etcd
[preflight] Pulling images required for setting up a Kubernetes cluster
[preflight] This might take a minute or two, depending on the speed of your internet connection
[preflight] You can also perform this action in beforehand using 'kubeadm config images pull'
I0520 18:08:00.092605    8809 checks.go:830] using image pull policy: IfNotPresent
W0520 18:08:00.115796    8809 checks.go:844] detected that the sandbox image "registry.k8s.io/pause:3.6" of the container runtime is inconsistent with that used by kubeadm.It is recommended to use "registry.k8s.io/pause:3.9" as the CRI sandbox image.
I0520 18:08:00.143688    8809 checks.go:862] image exists: registry.k8s.io/kube-apiserver:v1.30.1
I0520 18:08:00.168696    8809 checks.go:862] image exists: registry.k8s.io/kube-controller-manager:v1.30.1
I0520 18:08:00.193371    8809 checks.go:862] image exists: registry.k8s.io/kube-scheduler:v1.30.1
I0520 18:08:00.218870    8809 checks.go:862] image exists: registry.k8s.io/kube-proxy:v1.30.1
I0520 18:08:00.244135    8809 checks.go:862] image exists: registry.k8s.io/coredns/coredns:v1.11.1
I0520 18:08:00.271019    8809 checks.go:862] image exists: registry.k8s.io/pause:3.9
I0520 18:08:00.298729    8809 checks.go:862] image exists: registry.k8s.io/etcd:3.5.12-0
[certs] Using certificateDir folder "/etc/kubernetes/pki"
I0520 18:08:00.298876    8809 certs.go:112] creating a new certificate authority for ca
[certs] Generating "ca" certificate and key
I0520 18:08:00.411072    8809 certs.go:483] validating certificate period for ca certificate
[certs] Generating "apiserver" certificate and key
[certs] apiserver serving cert is signed for DNS names [kubernetes kubernetes.default kubernetes.default.svc kubernetes.default.svc.cluster.local master] and IPs [10.96.0.1 192.168.0.193]
[certs] Generating "apiserver-kubelet-client" certificate and key
I0520 18:08:00.798327    8809 certs.go:112] creating a new certificate authority for front-proxy-ca
[certs] Generating "front-proxy-ca" certificate and key
I0520 18:08:01.269801    8809 certs.go:483] validating certificate period for front-proxy-ca certificate
[certs] Generating "front-proxy-client" certificate and key
I0520 18:08:01.401058    8809 certs.go:112] creating a new certificate authority for etcd-ca
[certs] Generating "etcd/ca" certificate and key
I0520 18:08:01.544753    8809 certs.go:483] validating certificate period for etcd/ca certificate
[certs] Generating "etcd/server" certificate and key
[certs] etcd/server serving cert is signed for DNS names [localhost master] and IPs [192.168.0.193 127.0.0.1 ::1]
[certs] Generating "etcd/peer" certificate and key
[certs] etcd/peer serving cert is signed for DNS names [localhost master] and IPs [192.168.0.193 127.0.0.1 ::1]
[certs] Generating "etcd/healthcheck-client" certificate and key
[certs] Generating "apiserver-etcd-client" certificate and key
I0520 18:08:02.331404    8809 certs.go:78] creating new public/private key files for signing service account users
[certs] Generating "sa" key and public key
[kubeconfig] Using kubeconfig folder "/etc/kubernetes"
I0520 18:08:02.507045    8809 kubeconfig.go:112] creating kubeconfig file for admin.conf
[kubeconfig] Writing "admin.conf" kubeconfig file
I0520 18:08:02.590748    8809 kubeconfig.go:112] creating kubeconfig file for super-admin.conf
[kubeconfig] Writing "super-admin.conf" kubeconfig file
I0520 18:08:02.739320    8809 kubeconfig.go:112] creating kubeconfig file for kubelet.conf
[kubeconfig] Writing "kubelet.conf" kubeconfig file
I0520 18:08:02.978452    8809 kubeconfig.go:112] creating kubeconfig file for controller-manager.conf
[kubeconfig] Writing "controller-manager.conf" kubeconfig file
I0520 18:08:03.658420    8809 kubeconfig.go:112] creating kubeconfig file for scheduler.conf
[kubeconfig] Writing "scheduler.conf" kubeconfig file
[etcd] Creating static Pod manifest for local etcd in "/etc/kubernetes/manifests"
I0520 18:08:03.723206    8809 local.go:65] [etcd] wrote Static Pod manifest for a local etcd member to "/etc/kubernetes/manifests/etcd.yaml"
[control-plane] Using manifest folder "/etc/kubernetes/manifests"
[control-plane] Creating static Pod manifest for "kube-apiserver"
I0520 18:08:03.723925    8809 manifests.go:103] [control-plane] getting StaticPodSpecs
I0520 18:08:03.724080    8809 certs.go:483] validating certificate period for CA certificate
I0520 18:08:03.724240    8809 manifests.go:129] [control-plane] adding volume "ca-certs" for component "kube-apiserver"
I0520 18:08:03.724463    8809 manifests.go:129] [control-plane] adding volume "etc-ca-certificates" for component "kube-apiserver"
I0520 18:08:03.724640    8809 manifests.go:129] [control-plane] adding volume "k8s-certs" for component "kube-apiserver"
I0520 18:08:03.724690    8809 manifests.go:129] [control-plane] adding volume "usr-local-share-ca-certificates" for component "kube-apiserver"
I0520 18:08:03.724700    8809 manifests.go:129] [control-plane] adding volume "usr-share-ca-certificates" for component "kube-apiserver"
I0520 18:08:03.725467    8809 manifests.go:158] [control-plane] wrote static Pod manifest for component "kube-apiserver" to "/etc/kubernetes/manifests/kube-apiserver.yaml"
[control-plane] Creating static Pod manifest for "kube-controller-manager"
I0520 18:08:03.726176    8809 manifests.go:103] [control-plane] getting StaticPodSpecs
I0520 18:08:03.726707    8809 manifests.go:129] [control-plane] adding volume "ca-certs" for component "kube-controller-manager"
I0520 18:08:03.727020    8809 manifests.go:129] [control-plane] adding volume "etc-ca-certificates" for component "kube-controller-manager"
I0520 18:08:03.727227    8809 manifests.go:129] [control-plane] adding volume "flexvolume-dir" for component "kube-controller-manager"
I0520 18:08:03.727239    8809 manifests.go:129] [control-plane] adding volume "k8s-certs" for component "kube-controller-manager"
I0520 18:08:03.727306    8809 manifests.go:129] [control-plane] adding volume "kubeconfig" for component "kube-controller-manager"
I0520 18:08:03.727315    8809 manifests.go:129] [control-plane] adding volume "usr-local-share-ca-certificates" for component "kube-controller-manager"
I0520 18:08:03.727323    8809 manifests.go:129] [control-plane] adding volume "usr-share-ca-certificates" for component "kube-controller-manager"
I0520 18:08:03.727886    8809 manifests.go:158] [control-plane] wrote static Pod manifest for component "kube-controller-manager" to "/etc/kubernetes/manifests/kube-controller-manager.yaml"
[control-plane] Creating static Pod manifest for "kube-scheduler"
I0520 18:08:03.728565    8809 manifests.go:103] [control-plane] getting StaticPodSpecs
I0520 18:08:03.728983    8809 manifests.go:129] [control-plane] adding volume "kubeconfig" for component "kube-scheduler"
I0520 18:08:03.729325    8809 manifests.go:158] [control-plane] wrote static Pod manifest for component "kube-scheduler" to "/etc/kubernetes/manifests/kube-scheduler.yaml"
I0520 18:08:03.729604    8809 kubelet.go:68] Stopping the kubelet
[kubelet-start] Writing kubelet environment file with flags to file "/var/lib/kubelet/kubeadm-flags.env"
[kubelet-start] Writing kubelet configuration to file "/var/lib/kubelet/config.yaml"
[kubelet-start] Starting the kubelet
[wait-control-plane] Waiting for the kubelet to boot up the control plane as static Pods from directory "/etc/kubernetes/manifests"
[kubelet-check] Waiting for a healthy kubelet. This can take up to 4m0s
[kubelet-check] The kubelet is healthy after 501.498431ms
[api-check] Waiting for a healthy API server. This can take up to 4m0s
[api-check] The API server is healthy after 4.00590091s
I0520 18:08:08.537159    8809 kubeconfig.go:608] ensuring that the ClusterRoleBinding for the kubeadm:cluster-admins Group exists
I0520 18:08:08.543582    8809 kubeconfig.go:681] creating the ClusterRoleBinding for the kubeadm:cluster-admins Group by using super-admin.conf
I0520 18:08:08.563028    8809 uploadconfig.go:112] [upload-config] Uploading the kubeadm ClusterConfiguration to a ConfigMap
[upload-config] Storing the configuration used in ConfigMap "kubeadm-config" in the "kube-system" Namespace
I0520 18:08:08.580724    8809 uploadconfig.go:126] [upload-config] Uploading the kubelet component config to a ConfigMap
[kubelet] Creating a ConfigMap "kubelet-config" in namespace kube-system with the configuration for the kubelets in the cluster
I0520 18:08:08.590417    8809 uploadconfig.go:131] [upload-config] Preserving the CRISocket information for the control-plane node
I0520 18:08:08.590445    8809 patchnode.go:31] [patchnode] Uploading the CRI Socket information "unix:///var/run/containerd/containerd.sock" to the Node API object "master" as an annotation
[upload-certs] Skipping phase. Please see --upload-certs
[mark-control-plane] Marking the node master as control-plane by adding the labels: [node-role.kubernetes.io/control-plane node.kubernetes.io/exclude-from-external-load-balancers]
[mark-control-plane] Marking the node master as control-plane by adding the taints [node-role.kubernetes.io/control-plane:NoSchedule]
[bootstrap-token] Using token: 21my11.5vyxsuy0ksp08n13
[bootstrap-token] Configuring bootstrap tokens, cluster-info ConfigMap, RBAC Roles
[bootstrap-token] Configured RBAC rules to allow Node Bootstrap tokens to get nodes
[bootstrap-token] Configured RBAC rules to allow Node Bootstrap tokens to post CSRs in order for nodes to get long term certificate credentials
[bootstrap-token] Configured RBAC rules to allow the csrapprover controller automatically approve CSRs from a Node Bootstrap Token
[bootstrap-token] Configured RBAC rules to allow certificate rotation for all node client certificates in the cluster
[bootstrap-token] Creating the "cluster-info" ConfigMap in the "kube-public" namespace
I0520 18:08:08.631814    8809 clusterinfo.go:47] [bootstrap-token] loading admin kubeconfig
I0520 18:08:08.632176    8809 clusterinfo.go:58] [bootstrap-token] copying the cluster from admin.conf to the bootstrap kubeconfig
I0520 18:08:08.632321    8809 clusterinfo.go:70] [bootstrap-token] creating/updating ConfigMap in kube-public namespace
I0520 18:08:08.635272    8809 clusterinfo.go:84] creating the RBAC rules for exposing the cluster-info ConfigMap in the kube-public namespace
I0520 18:08:08.740252    8809 request.go:629] Waited for 104.696259ms due to client-side throttling, not priority and fairness, request: POST:https://192.168.0.193:6443/apis/rbac.authorization.k8s.io/v1/namespaces/kube-public/roles?timeout=10s
I0520 18:08:08.939500    8809 request.go:629] Waited for 172.929383ms due to client-side throttling, not priority and fairness, request: POST:https://192.168.0.193:6443/apis/rbac.authorization.k8s.io/v1/namespaces/kube-public/rolebindings?timeout=10s
I0520 18:08:08.945251    8809 kubeletfinalize.go:91] [kubelet-finalize] Assuming that kubelet client certificate rotation is enabled: found "/var/lib/kubelet/pki/kubelet-client-current.pem"
[kubelet-finalize] Updating "/etc/kubernetes/kubelet.conf" to point to a rotatable kubelet client certificate and key
I0520 18:08:08.946686    8809 kubeletfinalize.go:145] [kubelet-finalize] Restarting the kubelet to enable client certificate rotation
[addons] Applied essential addon: CoreDNS
I0520 18:08:09.571723    8809 request.go:629] Waited for 174.435339ms due to client-side throttling, not priority and fairness, request: POST:https://192.168.0.193:6443/api/v1/namespaces/kube-system/serviceaccounts?timeout=10s
I0520 18:08:09.738887    8809 request.go:629] Waited for 156.277838ms due to client-side throttling, not priority and fairness, request: POST:https://192.168.0.193:6443/apis/rbac.authorization.k8s.io/v1/namespaces/kube-system/roles?timeout=10s
I0520 18:08:09.939918    8809 request.go:629] Waited for 196.697988ms due to client-side throttling, not priority and fairness, request: POST:https://192.168.0.193:6443/apis/rbac.authorization.k8s.io/v1/namespaces/kube-system/rolebindings?timeout=10s
[addons] Applied essential addon: kube-proxy

Your Kubernetes control-plane has initialized successfully!

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

kubeadm join 192.168.0.193:6443 --token 21my11.5vyxsuy0ksp08n13 \
	--discovery-token-ca-cert-hash sha256:a583a8ea6c5c116dbd177a404688b059125b498a8f33d09cdd7beaf540d6dbfc 
master@master:~$ mkdir -p $HOME/.kube
master@master:~$ sudo cp -i /etc/kubernetes/admin.conf $HOME/.kube/config
cp: overwrite '/home/master/.kube/config'? 
master@master:~$ sudo chown $(id -u):$(id -g) $HOME/.kube/config
master@master:~$ sudo kubectl apply -f tigera-operator.yaml --validate=false
E0520 18:09:37.363857    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.365215    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.366552    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.368086    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.369260    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.371468    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.372238    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.379322    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.382924    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.383502    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.385466    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.386207    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.387994    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.388845    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.391998    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.392907    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.394534    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.397775    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.398288    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.406021    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.407071    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.483652    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.486787    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.487297    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.489631    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.490077    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:09:37.492143    9909 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "tigera-operator.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
master@master:~$ sudo vi tigera-operator.yaml 
master@master:~$ kubectl create -f https://raw.githubusercontent.com/projectcalico/calico/v3.28.0/manifests/custom-resources.yaml
error: error loading config file "/etc/kubernetes/admin.conf": open /etc/kubernetes/admin.conf: permission denied
master@master:~$ sudo kubectl create -f https://raw.githubusercontent.com/projectcalico/calico/v3.28.0/manifests/custom-resources.yaml
error: error validating "https://raw.githubusercontent.com/projectcalico/calico/v3.28.0/manifests/custom-resources.yaml": error validating data: failed to download openapi: Get "http://localhost:8080/openapi/v2?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused; if you choose to ignore these errors, turn validation off with --validate=false
master@master:~$ wget https://raw.githubusercontent.com/projectcalico/calico/v3.28.0/manifests/custom-resources.yaml
--2024-05-20 18:12:12--  https://raw.githubusercontent.com/projectcalico/calico/v3.28.0/manifests/custom-resources.yaml
Resolving raw.githubusercontent.com (raw.githubusercontent.com)... 185.199.111.133, 185.199.108.133, 185.199.109.133, ...
Connecting to raw.githubusercontent.com (raw.githubusercontent.com)|185.199.111.133|:443... connected.
HTTP request sent, awaiting response... 200 OK
Length: 777 [text/plain]
Saving to: ‘custom-resources.yaml’

custom-resources.yaml                          100%[=================================================================================================>]     777  --.-KB/s    in 0s      

2024-05-20 18:12:13 (12.0 MB/s) - ‘custom-resources.yaml’ saved [777/777]

master@master:~$ vi custom-resources.yaml 
master@master:~$ sudo kubectl create -f custom-resources.yaml
error: error validating "custom-resources.yaml": error validating data: failed to download openapi: Get "http://localhost:8080/openapi/v2?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused; if you choose to ignore these errors, turn validation off with --validate=false
master@master:~$ sudo kubectl create -f custom-resources.yaml --validate=false
E0520 18:13:30.130655    9994 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:13:30.131080    9994 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "custom-resources.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "custom-resources.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
master@master:~$ sudo systemctl status kubelet
sudo systemctl status kube-apiserver
sudo systemctl status kube-controller-manager
sudo systemctl status kube-scheduler
● kubelet.service - kubelet: The Kubernetes Node Agent
     Loaded: loaded (/usr/lib/systemd/system/kubelet.service; enabled; preset: enabled)
    Drop-In: /usr/lib/systemd/system/kubelet.service.d
             └─10-kubeadm.conf
     Active: active (running) since Mon 2024-05-20 18:08:09 UTC; 6min ago
       Docs: https://kubernetes.io/docs/
   Main PID: 9310 (kubelet)
      Tasks: 12 (limit: 9388)
     Memory: 33.7M (peak: 34.9M)
        CPU: 25.596s
     CGroup: /system.slice/kubelet.service
             └─9310 /usr/bin/kubelet --bootstrap-kubeconfig=/etc/kubernetes/bootstrap-kubelet.conf --kubeconfig=/etc/kubernetes/kubelet.conf --config=/var/lib/kubelet/config.yaml --container-runtime-endpoint=unix:///var/run/containerd/containerd.sock --pod-infra-container-image=registry.k8s.io/pause:3.9

May 20 18:13:24 master kubelet[9310]: E0520 18:13:24.717932    9310 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:13:29 master kubelet[9310]: E0520 18:13:29.720863    9310 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:13:34 master kubelet[9310]: E0520 18:13:34.723841    9310 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:13:39 master kubelet[9310]: E0520 18:13:39.728545    9310 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:13:44 master kubelet[9310]: E0520 18:13:44.730766    9310 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:13:49 master kubelet[9310]: E0520 18:13:49.732176    9310 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:13:54 master kubelet[9310]: E0520 18:13:54.734075    9310 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:13:59 master kubelet[9310]: E0520 18:13:59.735193    9310 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:14:04 master kubelet[9310]: E0520 18:14:04.738878    9310 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:14:09 master kubelet[9310]: E0520 18:14:09.744096    9310 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
Unit kube-apiserver.service could not be found.
Unit kube-controller-manager.service could not be found.
Unit kube-scheduler.service could not be found.
master@master:~$ sudo systemctl status kubelet
● kubelet.service - kubelet: The Kubernetes Node Agent
     Loaded: loaded (/usr/lib/systemd/system/kubelet.service; enabled; preset: enabled)
    Drop-In: /usr/lib/systemd/system/kubelet.service.d
             └─10-kubeadm.conf
     Active: active (running) since Mon 2024-05-20 18:08:09 UTC; 6min ago
       Docs: https://kubernetes.io/docs/
   Main PID: 9310 (kubelet)
      Tasks: 12 (limit: 9388)
     Memory: 33.7M (peak: 34.9M)
        CPU: 27.650s
     CGroup: /system.slice/kubelet.service
             └─9310 /usr/bin/kubelet --bootstrap-kubeconfig=/etc/kubernetes/bootstrap-kubelet.conf --kubeconfig=/etc/kubernetes/kubelet.conf --config=/var/lib/kubelet/config.yaml --container-runtime-endpoint=unix:///var/run/containerd/containerd.sock --pod-infra-container-image=registry.k8s.io/pause:3.9

May 20 18:14:14 master kubelet[9310]: E0520 18:14:14.747476    9310 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:14:19 master kubelet[9310]: E0520 18:14:19.752097    9310 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:14:24 master kubelet[9310]: E0520 18:14:24.756465    9310 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:14:29 master kubelet[9310]: E0520 18:14:29.758291    9310 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:14:34 master kubelet[9310]: E0520 18:14:34.761739    9310 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:14:39 master kubelet[9310]: E0520 18:14:39.764900    9310 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:14:44 master kubelet[9310]: E0520 18:14:44.767489    9310 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:14:49 master kubelet[9310]: E0520 18:14:49.771184    9310 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:14:54 master kubelet[9310]: E0520 18:14:54.775972    9310 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:14:59 master kubelet[9310]: E0520 18:14:59.778365    9310 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
master@master:~$ sudo systemctl status kube-controller-manager
Unit kube-controller-manager.service could not be found.
master@master:~$ sudo kubeadm reset -f
[reset] Reading configuration from the cluster...
[reset] FYI: You can look at this config file with 'kubectl -n kube-system get cm kubeadm-config -o yaml'
[preflight] Running pre-flight checks
[reset] Deleted contents of the etcd data directory: /var/lib/etcd
[reset] Stopping the kubelet service
[reset] Unmounting mounted directories in "/var/lib/kubelet"
[reset] Deleting contents of directories: [/etc/kubernetes/manifests /var/lib/kubelet /etc/kubernetes/pki]
[reset] Deleting files: [/etc/kubernetes/admin.conf /etc/kubernetes/super-admin.conf /etc/kubernetes/kubelet.conf /etc/kubernetes/bootstrap-kubelet.conf /etc/kubernetes/controller-manager.conf /etc/kubernetes/scheduler.conf]

The reset process does not clean CNI configuration. To do so, you must remove /etc/cni/net.d

The reset process does not reset or clean up iptables rules or IPVS tables.
If you wish to reset iptables, you must do so manually by using the "iptables" command.

If your cluster was setup to utilize IPVS, run ipvsadm --clear (or similar)
to reset your system's IPVS tables.

The reset process does not clean your kubeconfig files and you must remove them manually.
Please, check the contents of the $HOME/.kube/config file.
master@master:~$ sudo kubeadm init --pod-network-cidr=192.168.0.0/16
[init] Using Kubernetes version: v1.30.1
[preflight] Running pre-flight checks
[preflight] Pulling images required for setting up a Kubernetes cluster
[preflight] This might take a minute or two, depending on the speed of your internet connection
[preflight] You can also perform this action in beforehand using 'kubeadm config images pull'
W0520 18:16:01.305103   10433 checks.go:844] detected that the sandbox image "registry.k8s.io/pause:3.6" of the container runtime is inconsistent with that used by kubeadm.It is recommended to use "registry.k8s.io/pause:3.9" as the CRI sandbox image.
[certs] Using certificateDir folder "/etc/kubernetes/pki"
[certs] Generating "ca" certificate and key
[certs] Generating "apiserver" certificate and key
[certs] apiserver serving cert is signed for DNS names [kubernetes kubernetes.default kubernetes.default.svc kubernetes.default.svc.cluster.local master] and IPs [10.96.0.1 192.168.0.193]
[certs] Generating "apiserver-kubelet-client" certificate and key
[certs] Generating "front-proxy-ca" certificate and key
[certs] Generating "front-proxy-client" certificate and key
[certs] Generating "etcd/ca" certificate and key
[certs] Generating "etcd/server" certificate and key
[certs] etcd/server serving cert is signed for DNS names [localhost master] and IPs [192.168.0.193 127.0.0.1 ::1]
[certs] Generating "etcd/peer" certificate and key
[certs] etcd/peer serving cert is signed for DNS names [localhost master] and IPs [192.168.0.193 127.0.0.1 ::1]
[certs] Generating "etcd/healthcheck-client" certificate and key
[certs] Generating "apiserver-etcd-client" certificate and key
[certs] Generating "sa" key and public key
[kubeconfig] Using kubeconfig folder "/etc/kubernetes"
[kubeconfig] Writing "admin.conf" kubeconfig file
[kubeconfig] Writing "super-admin.conf" kubeconfig file
[kubeconfig] Writing "kubelet.conf" kubeconfig file
[kubeconfig] Writing "controller-manager.conf" kubeconfig file
[kubeconfig] Writing "scheduler.conf" kubeconfig file
[etcd] Creating static Pod manifest for local etcd in "/etc/kubernetes/manifests"
[control-plane] Using manifest folder "/etc/kubernetes/manifests"
[control-plane] Creating static Pod manifest for "kube-apiserver"
[control-plane] Creating static Pod manifest for "kube-controller-manager"
[control-plane] Creating static Pod manifest for "kube-scheduler"
[kubelet-start] Writing kubelet environment file with flags to file "/var/lib/kubelet/kubeadm-flags.env"
[kubelet-start] Writing kubelet configuration to file "/var/lib/kubelet/config.yaml"
[kubelet-start] Starting the kubelet
[wait-control-plane] Waiting for the kubelet to boot up the control plane as static Pods from directory "/etc/kubernetes/manifests"
[kubelet-check] Waiting for a healthy kubelet. This can take up to 4m0s
[kubelet-check] The kubelet is healthy after 504.515954ms
[api-check] Waiting for a healthy API server. This can take up to 4m0s
[api-check] The API server is healthy after 3.501865375s
[upload-config] Storing the configuration used in ConfigMap "kubeadm-config" in the "kube-system" Namespace
[kubelet] Creating a ConfigMap "kubelet-config" in namespace kube-system with the configuration for the kubelets in the cluster
[upload-certs] Skipping phase. Please see --upload-certs
[mark-control-plane] Marking the node master as control-plane by adding the labels: [node-role.kubernetes.io/control-plane node.kubernetes.io/exclude-from-external-load-balancers]
[mark-control-plane] Marking the node master as control-plane by adding the taints [node-role.kubernetes.io/control-plane:NoSchedule]
[bootstrap-token] Using token: 38bmb4.eae5efd7ku0dp6fb
[bootstrap-token] Configuring bootstrap tokens, cluster-info ConfigMap, RBAC Roles
[bootstrap-token] Configured RBAC rules to allow Node Bootstrap tokens to get nodes
[bootstrap-token] Configured RBAC rules to allow Node Bootstrap tokens to post CSRs in order for nodes to get long term certificate credentials
[bootstrap-token] Configured RBAC rules to allow the csrapprover controller automatically approve CSRs from a Node Bootstrap Token
[bootstrap-token] Configured RBAC rules to allow certificate rotation for all node client certificates in the cluster
[bootstrap-token] Creating the "cluster-info" ConfigMap in the "kube-public" namespace
[kubelet-finalize] Updating "/etc/kubernetes/kubelet.conf" to point to a rotatable kubelet client certificate and key
[addons] Applied essential addon: CoreDNS
[addons] Applied essential addon: kube-proxy

Your Kubernetes control-plane has initialized successfully!

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

kubeadm join 192.168.0.193:6443 --token 38bmb4.eae5efd7ku0dp6fb \
	--discovery-token-ca-cert-hash sha256:dff522fecb5c6d887f0d3f86133f206099bc7c3170d1aacf9376d78afd9109bf 
master@master:~$ sudo systemctl status kubelet
● kubelet.service - kubelet: The Kubernetes Node Agent
     Loaded: loaded (/usr/lib/systemd/system/kubelet.service; enabled; preset: enabled)
    Drop-In: /usr/lib/systemd/system/kubelet.service.d
             └─10-kubeadm.conf
     Active: active (running) since Mon 2024-05-20 18:16:09 UTC; 17s ago
       Docs: https://kubernetes.io/docs/
   Main PID: 10932 (kubelet)
      Tasks: 13 (limit: 9388)
     Memory: 26.1M (peak: 27.0M)
        CPU: 1.933s
     CGroup: /system.slice/kubelet.service
             └─10932 /usr/bin/kubelet --bootstrap-kubeconfig=/etc/kubernetes/bootstrap-kubelet.conf --kubeconfig=/etc/kubernetes/kubelet.conf --config=/var/lib/kubelet/config.yaml --container-runtime-endpoint=unix:///var/run/containerd/containerd.sock --pod-infra-container-image=registry.k8s.io/pause:3.9

May 20 18:16:10 master kubelet[10932]: I0520 18:16:10.454783   10932 pod_startup_latency_tracker.go:104] "Observed pod startup duration" pod="kube-system/kube-apiserver-master" podStartSLOduration=1.454765581 podStartE2EDuration="1.454765581s" podCreationTimestamp="2024-05-20 18:16:09 +0000 UTC" firstStartedPulling="0001-01-01 00:00:00 +0000 UTC" lastFinishedPulling="0001-01-01 00:00:00 +0000 UTC" observedRunningTime="2024-05-20 18:16:10.447519988 +0000 UTC m=+1.194272344" watchObservedRunningTime="2024-05-20 18:16:10.454765581 +0000 UTC m=+1.201517939"
May 20 18:16:10 master kubelet[10932]: I0520 18:16:10.466047   10932 pod_startup_latency_tracker.go:104] "Observed pod startup duration" pod="kube-system/etcd-master" podStartSLOduration=1.466032849 podStartE2EDuration="1.466032849s" podCreationTimestamp="2024-05-20 18:16:09 +0000 UTC" firstStartedPulling="0001-01-01 00:00:00 +0000 UTC" lastFinishedPulling="0001-01-01 00:00:00 +0000 UTC" observedRunningTime="2024-05-20 18:16:10.45516451 +0000 UTC m=+1.201916866" watchObservedRunningTime="2024-05-20 18:16:10.466032849 +0000 UTC m=+1.212785204"
May 20 18:16:16 master kubelet[10932]: I0520 18:16:16.429926   10932 pod_startup_latency_tracker.go:104] "Observed pod startup duration" pod="kube-system/kube-controller-manager-master" podStartSLOduration=7.429907618 podStartE2EDuration="7.429907618s" podCreationTimestamp="2024-05-20 18:16:09 +0000 UTC" firstStartedPulling="0001-01-01 00:00:00 +0000 UTC" lastFinishedPulling="0001-01-01 00:00:00 +0000 UTC" observedRunningTime="2024-05-20 18:16:10.466261278 +0000 UTC m=+1.213013634" watchObservedRunningTime="2024-05-20 18:16:16.429907618 +0000 UTC m=+7.176659995"
May 20 18:16:25 master kubelet[10932]: I0520 18:16:25.047204   10932 kuberuntime_manager.go:1523] "Updating runtime config through cri with podcidr" CIDR="192.168.0.0/24"
May 20 18:16:25 master kubelet[10932]: I0520 18:16:25.048029   10932 kubelet_network.go:61] "Updating Pod CIDR" originalPodCIDR="" newPodCIDR="192.168.0.0/24"
May 20 18:16:25 master kubelet[10932]: I0520 18:16:25.184350   10932 topology_manager.go:215] "Topology Admit Handler" podUID="358945ae-81f3-47bc-88b1-dc634f3121e8" podNamespace="kube-system" podName="kube-proxy-94ccg"
May 20 18:16:25 master kubelet[10932]: I0520 18:16:25.376517   10932 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"kube-proxy\" (UniqueName: \"kubernetes.io/configmap/358945ae-81f3-47bc-88b1-dc634f3121e8-kube-proxy\") pod \"kube-proxy-94ccg\" (UID: \"358945ae-81f3-47bc-88b1-dc634f3121e8\") " pod="kube-system/kube-proxy-94ccg"
May 20 18:16:25 master kubelet[10932]: I0520 18:16:25.376644   10932 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"xtables-lock\" (UniqueName: \"kubernetes.io/host-path/358945ae-81f3-47bc-88b1-dc634f3121e8-xtables-lock\") pod \"kube-proxy-94ccg\" (UID: \"358945ae-81f3-47bc-88b1-dc634f3121e8\") " pod="kube-system/kube-proxy-94ccg"
May 20 18:16:25 master kubelet[10932]: I0520 18:16:25.376853   10932 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"lib-modules\" (UniqueName: \"kubernetes.io/host-path/358945ae-81f3-47bc-88b1-dc634f3121e8-lib-modules\") pod \"kube-proxy-94ccg\" (UID: \"358945ae-81f3-47bc-88b1-dc634f3121e8\") " pod="kube-system/kube-proxy-94ccg"
May 20 18:16:25 master kubelet[10932]: I0520 18:16:25.376905   10932 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"kube-api-access-bqncx\" (UniqueName: \"kubernetes.io/projected/358945ae-81f3-47bc-88b1-dc634f3121e8-kube-api-access-bqncx\") pod \"kube-proxy-94ccg\" (UID: \"358945ae-81f3-47bc-88b1-dc634f3121e8\") " pod="kube-system/kube-proxy-94ccg"
master@master:~$ kubectl get componentstatuses
error: error loading config file "/etc/kubernetes/admin.conf": open /etc/kubernetes/admin.conf: permission denied
master@master:~$ sudo kubectl get componentstatuses
E0520 18:16:45.286265   11146 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:16:45.286797   11146 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:16:45.288373   11146 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:16:45.288795   11146 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:16:45.290182   11146 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
The connection to the server localhost:8080 was refused - did you specify the right host or port?
master@master:~$ mkdir -p $HOME/.kube
master@master:~$ sudo cp -i /etc/kubernetes/admin.conf $HOME/.kube/config
cp: overwrite '/home/master/.kube/config'? 
master@master:~$ sudo chown $(id -u):$(id -g) $HOME/.kube/config
master@master:~$ kubectl get componentstatuses
error: error loading config file "/etc/kubernetes/admin.conf": open /etc/kubernetes/admin.conf: permission denied
master@master:~$ sudo chmod -R 775 /etc/kubernetes/admin.conf
master@master:~$ kubectl get componentstatuses
Warning: v1 ComponentStatus is deprecated in v1.19+
NAME                 STATUS    MESSAGE   ERROR
controller-manager   Healthy   ok        
etcd-0               Healthy   ok        
scheduler            Healthy   ok        
master@master:~$ sudo kubectl create -f https://docs.projectcalico.org/manifests/calico.yaml --validate=false
E0520 18:19:21.077525   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.079048   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.080611   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.082799   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.090034   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.097019   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.100876   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.105767   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.107892   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.114240   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.143157   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.144124   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.145497   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.146515   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.147561   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.148296   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.150537   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.151546   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.154301   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.159527   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.161253   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.162220   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.163832   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.164435   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.166033   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.168163   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:21.168949   11196 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "https://docs.projectcalico.org/manifests/calico.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
master@master:~$ sudo kubectl create -f custom-resources.yaml --validate=false
E0520 18:19:47.690783   11208 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
E0520 18:19:47.691295   11208 memcache.go:265] couldn't get current server API group list: Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "custom-resources.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
unable to recognize "custom-resources.yaml": Get "http://localhost:8080/api?timeout=32s": dial tcp 127.0.0.1:8080: connect: connection refused
master@master:~$ sudo journalctl -u kube-apiserver -n 100 --no-pager
-- No entries --
master@master:~$ sudo systemctl status kube-apiserver
Unit kube-apiserver.service could not be found.
master@master:~$ systemctl status kube-apiserver
Unit kube-apiserver.service could not be found.
master@master:~$ systemctl list-unit-files | grep kube
kubelet.service                                                                       enabled         enabled
kubepods-besteffort-pod358945ae_81f3_47bc_88b1_dc634f3121e8.slice                     transient       -
kubepods-besteffort.slice                                                             transient       -
kubepods-burstable-pod15bdf4d723a547c5630424f1f7f130af.slice                          transient       -
kubepods-burstable-pod3efa7997bb3dcba687eb8ddec37317d4.slice                          transient       -
kubepods-burstable-pod69ee10a5eb64b7fbfd8088941c903bb4.slice                          transient       -
kubepods-burstable-podf4572e2f73797641acec3d310f32974a.slice                          transient       -
kubepods-burstable.slice                                                              transient       -
kubepods.slice                                                                        transient       -
master@master:~$ sudo kubeadm init --ignore-preflight-errors=Port-6443,Port-10259,Port-10257,FileAvailable--etc-kubernetes-manifests-kube-apiserver.yaml,FileAvailable--etc-kubernetes-manifests-kube-controller-manager.yaml,FileAvailable--etc-kubernetes-manifests-kube-scheduler.yaml,FileAvailable--etc-kubernetes-manifests-etcd.yaml,Port-10250,Port-2379,Port-2380,DirAvailable--var-lib-etcd
[init] Using Kubernetes version: v1.30.1
[preflight] Running pre-flight checks
	[WARNING Port-6443]: Port 6443 is in use
	[WARNING Port-10259]: Port 10259 is in use
	[WARNING Port-10257]: Port 10257 is in use
	[WARNING FileAvailable--etc-kubernetes-manifests-kube-apiserver.yaml]: /etc/kubernetes/manifests/kube-apiserver.yaml already exists
	[WARNING FileAvailable--etc-kubernetes-manifests-kube-controller-manager.yaml]: /etc/kubernetes/manifests/kube-controller-manager.yaml already exists
	[WARNING FileAvailable--etc-kubernetes-manifests-kube-scheduler.yaml]: /etc/kubernetes/manifests/kube-scheduler.yaml already exists
	[WARNING FileAvailable--etc-kubernetes-manifests-etcd.yaml]: /etc/kubernetes/manifests/etcd.yaml already exists
	[WARNING Port-10250]: Port 10250 is in use
	[WARNING Port-2379]: Port 2379 is in use
	[WARNING Port-2380]: Port 2380 is in use
	[WARNING DirAvailable--var-lib-etcd]: /var/lib/etcd is not empty
[preflight] Pulling images required for setting up a Kubernetes cluster
[preflight] This might take a minute or two, depending on the speed of your internet connection
[preflight] You can also perform this action in beforehand using 'kubeadm config images pull'
W0520 18:21:58.917307   11244 checks.go:844] detected that the sandbox image "registry.k8s.io/pause:3.6" of the container runtime is inconsistent with that used by kubeadm.It is recommended to use "registry.k8s.io/pause:3.9" as the CRI sandbox image.
[certs] Using certificateDir folder "/etc/kubernetes/pki"
[certs] Using existing ca certificate authority
[certs] Using existing apiserver certificate and key on disk
[certs] Using existing apiserver-kubelet-client certificate and key on disk
[certs] Using existing front-proxy-ca certificate authority
[certs] Using existing front-proxy-client certificate and key on disk
[certs] Using existing etcd/ca certificate authority
[certs] Using existing etcd/server certificate and key on disk
[certs] Using existing etcd/peer certificate and key on disk
[certs] Using existing etcd/healthcheck-client certificate and key on disk
[certs] Using existing apiserver-etcd-client certificate and key on disk
[certs] Using the existing "sa" key
[kubeconfig] Using kubeconfig folder "/etc/kubernetes"
[kubeconfig] Using existing kubeconfig file: "/etc/kubernetes/admin.conf"
[kubeconfig] Using existing kubeconfig file: "/etc/kubernetes/super-admin.conf"
[kubeconfig] Using existing kubeconfig file: "/etc/kubernetes/kubelet.conf"
[kubeconfig] Using existing kubeconfig file: "/etc/kubernetes/controller-manager.conf"
[kubeconfig] Using existing kubeconfig file: "/etc/kubernetes/scheduler.conf"
[etcd] Creating static Pod manifest for local etcd in "/etc/kubernetes/manifests"
[control-plane] Using manifest folder "/etc/kubernetes/manifests"
[control-plane] Creating static Pod manifest for "kube-apiserver"
[control-plane] Creating static Pod manifest for "kube-controller-manager"
[control-plane] Creating static Pod manifest for "kube-scheduler"
[kubelet-start] Writing kubelet environment file with flags to file "/var/lib/kubelet/kubeadm-flags.env"
[kubelet-start] Writing kubelet configuration to file "/var/lib/kubelet/config.yaml"
[kubelet-start] Starting the kubelet
[wait-control-plane] Waiting for the kubelet to boot up the control plane as static Pods from directory "/etc/kubernetes/manifests"
[kubelet-check] Waiting for a healthy kubelet. This can take up to 4m0s
[kubelet-check] The kubelet is healthy after 504.026391ms
[api-check] Waiting for a healthy API server. This can take up to 4m0s
[api-check] The API server is healthy after 24.239844ms
[upload-config] Storing the configuration used in ConfigMap "kubeadm-config" in the "kube-system" Namespace
[kubelet] Creating a ConfigMap "kubelet-config" in namespace kube-system with the configuration for the kubelets in the cluster
[upload-certs] Skipping phase. Please see --upload-certs
[mark-control-plane] Marking the node master as control-plane by adding the labels: [node-role.kubernetes.io/control-plane node.kubernetes.io/exclude-from-external-load-balancers]
[mark-control-plane] Marking the node master as control-plane by adding the taints [node-role.kubernetes.io/control-plane:NoSchedule]
[bootstrap-token] Using token: ihp440.ygpkb7l7p3p9w7qw
[bootstrap-token] Configuring bootstrap tokens, cluster-info ConfigMap, RBAC Roles
[bootstrap-token] Configured RBAC rules to allow Node Bootstrap tokens to get nodes
[bootstrap-token] Configured RBAC rules to allow Node Bootstrap tokens to post CSRs in order for nodes to get long term certificate credentials
[bootstrap-token] Configured RBAC rules to allow the csrapprover controller automatically approve CSRs from a Node Bootstrap Token
[bootstrap-token] Configured RBAC rules to allow certificate rotation for all node client certificates in the cluster
[bootstrap-token] Creating the "cluster-info" ConfigMap in the "kube-public" namespace
[kubelet-finalize] Updating "/etc/kubernetes/kubelet.conf" to point to a rotatable kubelet client certificate and key
[addons] Applied essential addon: CoreDNS
[addons] Applied essential addon: kube-proxy

Your Kubernetes control-plane has initialized successfully!

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

kubeadm join 192.168.0.193:6443 --token ihp440.ygpkb7l7p3p9w7qw \
	--discovery-token-ca-cert-hash sha256:dff522fecb5c6d887f0d3f86133f206099bc7c3170d1aacf9376d78afd9109bf 
master@master:~$ sudo systemctl status kube-apiserver
Unit kube-apiserver.service could not be found.
master@master:~$ mkdir -p $HOME/.kube
master@master:~$ sudo cp -i /etc/kubernetes/admin.conf $HOME/.kube/config
cp: overwrite '/home/master/.kube/config'? 
master@master:~$ sudo chown $(id -u):$(id -g) $HOME/.kube/config
master@master:~$ export KUBECONFIG=/etc/kubernetes/admin.conf
master@master:~$ sudo systemctl status kube-apiserver
Unit kube-apiserver.service could not be found.
master@master:~$ sudo systemctl start kube-apiserver
Failed to start kube-apiserver.service: Unit kube-apiserver.service not found.
master@master:~$ sudo systemctl status kube-controller-manager
Unit kube-controller-manager.service could not be found.
master@master:~$ kubectl create -f custom-resources.yaml --validate=false
resource mapping not found for name: "default" namespace: "" from "custom-resources.yaml": no matches for kind "Installation" in version "operator.tigera.io/v1"
ensure CRDs are installed first
resource mapping not found for name: "default" namespace: "" from "custom-resources.yaml": no matches for kind "APIServer" in version "operator.tigera.io/v1"
ensure CRDs are installed first
master@master:~$ sudo journalctl -u kubelet -n 100 --no-pager
May 20 18:22:03 master systemd[1]: Started kubelet.service - kubelet: The Kubernetes Node Agent.
May 20 18:22:03 master (kubelet)[11580]: kubelet.service: Referenced but unset environment variable evaluates to an empty string: KUBELET_EXTRA_ARGS
May 20 18:22:03 master kubelet[11580]: Flag --container-runtime-endpoint has been deprecated, This parameter should be set via the config file specified by the Kubelet's --config flag. See https://kubernetes.io/docs/tasks/administer-cluster/kubelet-config-file/ for more information.
May 20 18:22:03 master kubelet[11580]: Flag --pod-infra-container-image has been deprecated, will be removed in a future release. Image garbage collector will get sandbox image information from CRI.
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.821883   11580 server.go:205] "--pod-infra-container-image will not be pruned by the image garbage collector in kubelet and should also be set in the remote runtime"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.828277   11580 server.go:484] "Kubelet version" kubeletVersion="v1.30.1"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.828300   11580 server.go:486] "Golang settings" GOGC="" GOMAXPROCS="" GOTRACEBACK=""
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.828484   11580 server.go:927] "Client rotation is on, will bootstrap in background"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.829609   11580 certificate_store.go:130] Loading cert/key pair from "/var/lib/kubelet/pki/kubelet-client-current.pem".
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.830631   11580 dynamic_cafile_content.go:157] "Starting controller" name="client-ca-bundle::/etc/kubernetes/pki/ca.crt"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.841174   11580 server.go:742] "--cgroups-per-qos enabled, but --cgroup-root was not specified.  defaulting to /"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.841506   11580 container_manager_linux.go:265] "Container manager verified user specified cgroup-root exists" cgroupRoot=[]
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.841570   11580 container_manager_linux.go:270] "Creating Container Manager object based on Node Config" nodeConfig={"NodeName":"master","RuntimeCgroupsName":"","SystemCgroupsName":"","KubeletCgroupsName":"","KubeletOOMScoreAdj":-999,"ContainerRuntime":"","CgroupsPerQOS":true,"CgroupRoot":"/","CgroupDriver":"systemd","KubeletRootDir":"/var/lib/kubelet","ProtectKernelDefaults":false,"KubeReservedCgroupName":"","SystemReservedCgroupName":"","ReservedSystemCPUs":{},"EnforceNodeAllocatable":{"pods":{}},"KubeReserved":null,"SystemReserved":null,"HardEvictionThresholds":[{"Signal":"nodefs.inodesFree","Operator":"LessThan","Value":{"Quantity":null,"Percentage":0.05},"GracePeriod":0,"MinReclaim":null},{"Signal":"imagefs.available","Operator":"LessThan","Value":{"Quantity":null,"Percentage":0.15},"GracePeriod":0,"MinReclaim":null},{"Signal":"imagefs.inodesFree","Operator":"LessThan","Value":{"Quantity":null,"Percentage":0.05},"GracePeriod":0,"MinReclaim":null},{"Signal":"memory.available","Operator":"LessThan","Value":{"Quantity":"100Mi","Percentage":0},"GracePeriod":0,"MinReclaim":null},{"Signal":"nodefs.available","Operator":"LessThan","Value":{"Quantity":null,"Percentage":0.1},"GracePeriod":0,"MinReclaim":null}],"QOSReserved":{},"CPUManagerPolicy":"none","CPUManagerPolicyOptions":null,"TopologyManagerScope":"container","CPUManagerReconcilePeriod":10000000000,"ExperimentalMemoryManagerPolicy":"None","ExperimentalMemoryManagerReservedMemory":null,"PodPidsLimit":-1,"EnforceCPULimits":true,"CPUCFSQuotaPeriod":100000000,"TopologyManagerPolicy":"none","TopologyManagerPolicyOptions":null}
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.841735   11580 topology_manager.go:138] "Creating topology manager with none policy"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.841745   11580 container_manager_linux.go:301] "Creating device plugin manager"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.841785   11580 state_mem.go:36] "Initialized new in-memory state store"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.841952   11580 kubelet.go:400] "Attempting to sync node with API server"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.841969   11580 kubelet.go:301] "Adding static pod path" path="/etc/kubernetes/manifests"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.841987   11580 kubelet.go:312] "Adding apiserver pod source"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.841998   11580 apiserver.go:42] "Waiting for node sync before watching apiserver pods"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.842583   11580 kuberuntime_manager.go:261] "Container runtime initialized" containerRuntime="containerd" version="1.6.31" apiVersion="v1"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.842744   11580 kubelet.go:815] "Not starting ClusterTrustBundle informer because we are in static kubelet mode"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.843255   11580 server.go:1264] "Started kubelet"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.846559   11580 fs_resource_analyzer.go:67] "Starting FS ResourceAnalyzer"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.853516   11580 server.go:163] "Starting to listen" address="0.0.0.0" port=10250
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.856446   11580 ratelimit.go:55] "Setting rate limiting for endpoint" service="podresources" qps=100 burstTokens=10
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.857274   11580 server.go:227] "Starting to serve the podresources API" endpoint="unix:/var/lib/kubelet/pod-resources/kubelet.sock"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.859346   11580 volume_manager.go:291] "Starting Kubelet Volume Manager"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.859490   11580 desired_state_of_world_populator.go:149] "Desired state populator starts to run"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.859774   11580 server.go:455] "Adding debug handlers to kubelet server"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.859897   11580 reconciler.go:26] "Reconciler: start to sync state"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.866061   11580 factory.go:221] Registration of the systemd container factory successfully
May 20 18:22:03 master kubelet[11580]: E0520 18:22:03.867178   11580 kubelet.go:1467] "Image garbage collection failed once. Stats initialization may not have completed yet" err="invalid capacity 0 on image filesystem"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.867185   11580 factory.go:219] Registration of the crio container factory failed: Get "http://%2Fvar%2Frun%2Fcrio%2Fcrio.sock/info": dial unix /var/run/crio/crio.sock: connect: no such file or directory
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.869725   11580 factory.go:221] Registration of the containerd container factory successfully
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.877097   11580 kubelet_network_linux.go:50] "Initialized iptables rules." protocol="IPv4"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.878658   11580 kubelet_network_linux.go:50] "Initialized iptables rules." protocol="IPv6"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.878684   11580 status_manager.go:217] "Starting to sync pod status with apiserver"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.878699   11580 kubelet.go:2337] "Starting kubelet main sync loop"
May 20 18:22:03 master kubelet[11580]: E0520 18:22:03.878742   11580 kubelet.go:2361] "Skipping pod synchronization" err="[container runtime status check may not have completed yet, PLEG is not healthy: pleg has yet to be successful]"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.932611   11580 cpu_manager.go:214] "Starting CPU manager" policy="none"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.932708   11580 cpu_manager.go:215] "Reconciling" reconcilePeriod="10s"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.932730   11580 state_mem.go:36] "Initialized new in-memory state store"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.932895   11580 state_mem.go:88] "Updated default CPUSet" cpuSet=""
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.932905   11580 state_mem.go:96] "Updated CPUSet assignments" assignments={}
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.932921   11580 policy_none.go:49] "None policy: Start"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.933509   11580 memory_manager.go:170] "Starting memorymanager" policy="None"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.933540   11580 state_mem.go:35] "Initializing new in-memory state store"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.933691   11580 state_mem.go:75] "Updated machine memory state"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.938337   11580 manager.go:479] "Failed to read data from checkpoint" checkpoint="kubelet_internal_checkpoint" err="checkpoint is not found"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.938720   11580 container_log_manager.go:186] "Initializing container log rotate workers" workers=1 monitorPeriod="10s"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.938848   11580 plugin_manager.go:118] "Starting Kubelet Plugin Manager"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.960659   11580 kubelet_node_status.go:73] "Attempting to register node" node="master"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.967202   11580 kubelet_node_status.go:112] "Node was previously registered" node="master"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.967281   11580 kubelet_node_status.go:76] "Successfully registered node" node="master"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.968694   11580 kuberuntime_manager.go:1523] "Updating runtime config through cri with podcidr" CIDR="192.168.0.0/24"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.970562   11580 kubelet_network.go:61] "Updating Pod CIDR" originalPodCIDR="" newPodCIDR="192.168.0.0/24"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.978851   11580 topology_manager.go:215] "Topology Admit Handler" podUID="69ee10a5eb64b7fbfd8088941c903bb4" podNamespace="kube-system" podName="etcd-master"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.978964   11580 topology_manager.go:215] "Topology Admit Handler" podUID="3efa7997bb3dcba687eb8ddec37317d4" podNamespace="kube-system" podName="kube-apiserver-master"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.979194   11580 topology_manager.go:215] "Topology Admit Handler" podUID="4323188f28e6dc6f27657dca98efeda7" podNamespace="kube-system" podName="kube-controller-manager-master"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.980524   11580 topology_manager.go:215] "Topology Admit Handler" podUID="15bdf4d723a547c5630424f1f7f130af" podNamespace="kube-system" podName="kube-scheduler-master"
May 20 18:22:03 master kubelet[11580]: I0520 18:22:03.981555   11580 pod_container_deletor.go:80] "Container not found in pod's containers" containerID="541172b6a2b20b75f7f6eccd3bca803cf0a13e8eaa2068192d06cd8ff853a1e0"
May 20 18:22:04 master kubelet[11580]: E0520 18:22:04.003717   11580 kubelet.go:1928] "Failed creating a mirror pod for" err="pods \"etcd-master\" already exists" pod="kube-system/etcd-master"
May 20 18:22:04 master kubelet[11580]: E0520 18:22:04.005293   11580 kubelet.go:1928] "Failed creating a mirror pod for" err="pods \"kube-controller-manager-master\" already exists" pod="kube-system/kube-controller-manager-master"
May 20 18:22:04 master kubelet[11580]: E0520 18:22:04.006288   11580 kubelet.go:1928] "Failed creating a mirror pod for" err="pods \"kube-scheduler-master\" already exists" pod="kube-system/kube-scheduler-master"
May 20 18:22:04 master kubelet[11580]: E0520 18:22:04.006407   11580 kubelet.go:1928] "Failed creating a mirror pod for" err="pods \"kube-apiserver-master\" already exists" pod="kube-system/kube-apiserver-master"
May 20 18:22:04 master kubelet[11580]: I0520 18:22:04.068005   11580 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"ca-certs\" (UniqueName: \"kubernetes.io/host-path/3efa7997bb3dcba687eb8ddec37317d4-ca-certs\") pod \"kube-apiserver-master\" (UID: \"3efa7997bb3dcba687eb8ddec37317d4\") " pod="kube-system/kube-apiserver-master"
May 20 18:22:04 master kubelet[11580]: I0520 18:22:04.068141   11580 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"k8s-certs\" (UniqueName: \"kubernetes.io/host-path/4323188f28e6dc6f27657dca98efeda7-k8s-certs\") pod \"kube-controller-manager-master\" (UID: \"4323188f28e6dc6f27657dca98efeda7\") " pod="kube-system/kube-controller-manager-master"
May 20 18:22:04 master kubelet[11580]: I0520 18:22:04.068216   11580 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"kubeconfig\" (UniqueName: \"kubernetes.io/host-path/15bdf4d723a547c5630424f1f7f130af-kubeconfig\") pod \"kube-scheduler-master\" (UID: \"15bdf4d723a547c5630424f1f7f130af\") " pod="kube-system/kube-scheduler-master"
May 20 18:22:04 master kubelet[11580]: I0520 18:22:04.068269   11580 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"etcd-certs\" (UniqueName: \"kubernetes.io/host-path/69ee10a5eb64b7fbfd8088941c903bb4-etcd-certs\") pod \"etcd-master\" (UID: \"69ee10a5eb64b7fbfd8088941c903bb4\") " pod="kube-system/etcd-master"
May 20 18:22:04 master kubelet[11580]: I0520 18:22:04.068321   11580 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"k8s-certs\" (UniqueName: \"kubernetes.io/host-path/3efa7997bb3dcba687eb8ddec37317d4-k8s-certs\") pod \"kube-apiserver-master\" (UID: \"3efa7997bb3dcba687eb8ddec37317d4\") " pod="kube-system/kube-apiserver-master"
May 20 18:22:04 master kubelet[11580]: I0520 18:22:04.068375   11580 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"usr-local-share-ca-certificates\" (UniqueName: \"kubernetes.io/host-path/3efa7997bb3dcba687eb8ddec37317d4-usr-local-share-ca-certificates\") pod \"kube-apiserver-master\" (UID: \"3efa7997bb3dcba687eb8ddec37317d4\") " pod="kube-system/kube-apiserver-master"
May 20 18:22:04 master kubelet[11580]: I0520 18:22:04.068486   11580 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"flexvolume-dir\" (UniqueName: \"kubernetes.io/host-path/4323188f28e6dc6f27657dca98efeda7-flexvolume-dir\") pod \"kube-controller-manager-master\" (UID: \"4323188f28e6dc6f27657dca98efeda7\") " pod="kube-system/kube-controller-manager-master"
May 20 18:22:04 master kubelet[11580]: I0520 18:22:04.068544   11580 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"usr-share-ca-certificates\" (UniqueName: \"kubernetes.io/host-path/4323188f28e6dc6f27657dca98efeda7-usr-share-ca-certificates\") pod \"kube-controller-manager-master\" (UID: \"4323188f28e6dc6f27657dca98efeda7\") " pod="kube-system/kube-controller-manager-master"
May 20 18:22:04 master kubelet[11580]: I0520 18:22:04.068618   11580 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"etc-ca-certificates\" (UniqueName: \"kubernetes.io/host-path/3efa7997bb3dcba687eb8ddec37317d4-etc-ca-certificates\") pod \"kube-apiserver-master\" (UID: \"3efa7997bb3dcba687eb8ddec37317d4\") " pod="kube-system/kube-apiserver-master"
May 20 18:22:04 master kubelet[11580]: I0520 18:22:04.068678   11580 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"usr-share-ca-certificates\" (UniqueName: \"kubernetes.io/host-path/3efa7997bb3dcba687eb8ddec37317d4-usr-share-ca-certificates\") pod \"kube-apiserver-master\" (UID: \"3efa7997bb3dcba687eb8ddec37317d4\") " pod="kube-system/kube-apiserver-master"
May 20 18:22:04 master kubelet[11580]: I0520 18:22:04.068734   11580 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"etc-ca-certificates\" (UniqueName: \"kubernetes.io/host-path/4323188f28e6dc6f27657dca98efeda7-etc-ca-certificates\") pod \"kube-controller-manager-master\" (UID: \"4323188f28e6dc6f27657dca98efeda7\") " pod="kube-system/kube-controller-manager-master"
May 20 18:22:04 master kubelet[11580]: I0520 18:22:04.068784   11580 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"kubeconfig\" (UniqueName: \"kubernetes.io/host-path/4323188f28e6dc6f27657dca98efeda7-kubeconfig\") pod \"kube-controller-manager-master\" (UID: \"4323188f28e6dc6f27657dca98efeda7\") " pod="kube-system/kube-controller-manager-master"
May 20 18:22:04 master kubelet[11580]: I0520 18:22:04.068939   11580 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"usr-local-share-ca-certificates\" (UniqueName: \"kubernetes.io/host-path/4323188f28e6dc6f27657dca98efeda7-usr-local-share-ca-certificates\") pod \"kube-controller-manager-master\" (UID: \"4323188f28e6dc6f27657dca98efeda7\") " pod="kube-system/kube-controller-manager-master"
May 20 18:22:04 master kubelet[11580]: I0520 18:22:04.069009   11580 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"ca-certs\" (UniqueName: \"kubernetes.io/host-path/4323188f28e6dc6f27657dca98efeda7-ca-certs\") pod \"kube-controller-manager-master\" (UID: \"4323188f28e6dc6f27657dca98efeda7\") " pod="kube-system/kube-controller-manager-master"
May 20 18:22:04 master kubelet[11580]: I0520 18:22:04.069082   11580 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"etcd-data\" (UniqueName: \"kubernetes.io/host-path/69ee10a5eb64b7fbfd8088941c903bb4-etcd-data\") pod \"etcd-master\" (UID: \"69ee10a5eb64b7fbfd8088941c903bb4\") " pod="kube-system/etcd-master"
May 20 18:22:04 master kubelet[11580]: I0520 18:22:04.843199   11580 apiserver.go:52] "Watching apiserver"
May 20 18:22:04 master kubelet[11580]: I0520 18:22:04.848458   11580 topology_manager.go:215] "Topology Admit Handler" podUID="358945ae-81f3-47bc-88b1-dc634f3121e8" podNamespace="kube-system" podName="kube-proxy-94ccg"
May 20 18:22:04 master kubelet[11580]: I0520 18:22:04.860668   11580 desired_state_of_world_populator.go:157] "Finished populating initial desired state of world"
May 20 18:22:04 master kubelet[11580]: I0520 18:22:04.876245   11580 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"lib-modules\" (UniqueName: \"kubernetes.io/host-path/358945ae-81f3-47bc-88b1-dc634f3121e8-lib-modules\") pod \"kube-proxy-94ccg\" (UID: \"358945ae-81f3-47bc-88b1-dc634f3121e8\") " pod="kube-system/kube-proxy-94ccg"
May 20 18:22:04 master kubelet[11580]: I0520 18:22:04.876320   11580 reconciler_common.go:247] "operationExecutor.VerifyControllerAttachedVolume started for volume \"xtables-lock\" (UniqueName: \"kubernetes.io/host-path/358945ae-81f3-47bc-88b1-dc634f3121e8-xtables-lock\") pod \"kube-proxy-94ccg\" (UID: \"358945ae-81f3-47bc-88b1-dc634f3121e8\") " pod="kube-system/kube-proxy-94ccg"
May 20 18:22:04 master kubelet[11580]: E0520 18:22:04.910744   11580 kubelet.go:1928] "Failed creating a mirror pod for" err="pods \"kube-controller-manager-master\" already exists" pod="kube-system/kube-controller-manager-master"
May 20 18:22:04 master kubelet[11580]: E0520 18:22:04.912292   11580 kubelet.go:1928] "Failed creating a mirror pod for" err="pods \"kube-apiserver-master\" already exists" pod="kube-system/kube-apiserver-master"
May 20 18:22:04 master kubelet[11580]: E0520 18:22:04.912378   11580 kubelet.go:1928] "Failed creating a mirror pod for" err="pods \"etcd-master\" already exists" pod="kube-system/etcd-master"
May 20 18:22:04 master kubelet[11580]: E0520 18:22:04.912298   11580 kubelet.go:1928] "Failed creating a mirror pod for" err="pods \"kube-scheduler-master\" already exists" pod="kube-system/kube-scheduler-master"
May 20 18:22:05 master kubelet[11580]: I0520 18:22:05.894655   11580 kubelet_volumes.go:163] "Cleaned up orphaned pod volumes dir" podUID="f4572e2f73797641acec3d310f32974a" path="/var/lib/kubelet/pods/f4572e2f73797641acec3d310f32974a/volumes"
May 20 18:23:03 master kubelet[11580]: E0520 18:23:03.881039   11580 remote_runtime.go:432] "ContainerStatus from runtime service failed" err="rpc error: code = NotFound desc = an error occurred when try to find container \"152a5037b3954862e729c5c0f4e2093d3b4ac524d779bd2427f0a93c2433e0ff\": not found" containerID="152a5037b3954862e729c5c0f4e2093d3b4ac524d779bd2427f0a93c2433e0ff"
May 20 18:23:03 master kubelet[11580]: I0520 18:23:03.881091   11580 kuberuntime_gc.go:361] "Error getting ContainerStatus for containerID" containerID="152a5037b3954862e729c5c0f4e2093d3b4ac524d779bd2427f0a93c2433e0ff" err="rpc error: code = NotFound desc = an error occurred when try to find container \"152a5037b3954862e729c5c0f4e2093d3b4ac524d779bd2427f0a93c2433e0ff\": not found"
May 20 18:24:03 master kubelet[11580]: E0520 18:24:03.886621   11580 kubelet_node_status.go:456] "Node not becoming ready in time after startup"
May 20 18:24:04 master kubelet[11580]: E0520 18:24:04.014531   11580 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:24:09 master kubelet[11580]: E0520 18:24:09.018132   11580 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:24:14 master kubelet[11580]: E0520 18:24:14.019575   11580 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:24:19 master kubelet[11580]: E0520 18:24:19.023843   11580 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:24:24 master kubelet[11580]: E0520 18:24:24.028025   11580 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
May 20 18:24:29 master kubelet[11580]: E0520 18:24:29.031968   11580 kubelet.go:2900] "Container runtime network not ready" networkReady="NetworkReady=false reason:NetworkPluginNotReady message:Network plugin returns error: cni plugin not initialized"
master@master:~$ sudo kubeadm reset -f
[reset] Reading configuration from the cluster...
[reset] FYI: You can look at this config file with 'kubectl -n kube-system get cm kubeadm-config -o yaml'
[preflight] Running pre-flight checks
[reset] Deleted contents of the etcd data directory: /var/lib/etcd
[reset] Stopping the kubelet service
[reset] Unmounting mounted directories in "/var/lib/kubelet"
[reset] Deleting contents of directories: [/etc/kubernetes/manifests /var/lib/kubelet /etc/kubernetes/pki]
[reset] Deleting files: [/etc/kubernetes/admin.conf /etc/kubernetes/super-admin.conf /etc/kubernetes/kubelet.conf /etc/kubernetes/bootstrap-kubelet.conf /etc/kubernetes/controller-manager.conf /etc/kubernetes/scheduler.conf]

The reset process does not clean CNI configuration. To do so, you must remove /etc/cni/net.d

The reset process does not reset or clean up iptables rules or IPVS tables.
If you wish to reset iptables, you must do so manually by using the "iptables" command.

If your cluster was setup to utilize IPVS, run ipvsadm --clear (or similar)
to reset your system's IPVS tables.

The reset process does not clean your kubeconfig files and you must remove them manually.
Please, check the contents of the $HOME/.kube/config file.
master@master:~$ sudo kubeadm init --pod-network-cidr=192.168.0.0/16 --cri-socket /run/containerd/containerd.sock /var/run/
agetty.reload             cryptsetup/               initramfs/                mount/                    shm/                      systemd/                  xtables.lock
blkid/                    dbus/                     lock/                     multipath/                snapd-snap.socket         tmpfiles.d/               
cloud-init/               dmeventd-client           log/                      multipathd.pid            snapd.socket              udev/                     
console-setup/            dmeventd-server           lvm/                      needrestart/              sshd/                     unattended-upgrades.lock  
containerd/               fsck/                     lxd-installer.socket      sendsigs.omit.d/          sshd.pid                  user/                     
credentials/              initctl                   motd.dynamic              setrans/                  sudo/                     utmp                      
master@master:~$ sudo kubeadm init --pod-network-cidr=192.168.0.0/16 --cri-socket /var/run/containerd/containerd.sock
W0520 18:34:02.866759   12074 initconfiguration.go:125] Usage of CRI endpoints without URL scheme is deprecated and can cause kubelet errors in the future. Automatically prepending scheme "unix" to the "criSocket" with value "/var/run/containerd/containerd.sock". Please update your configuration!
[init] Using Kubernetes version: v1.30.1
[preflight] Running pre-flight checks
[preflight] Pulling images required for setting up a Kubernetes cluster
[preflight] This might take a minute or two, depending on the speed of your internet connection
[preflight] You can also perform this action in beforehand using 'kubeadm config images pull'
W0520 18:34:03.917539   12074 checks.go:844] detected that the sandbox image "registry.k8s.io/pause:3.6" of the container runtime is inconsistent with that used by kubeadm.It is recommended to use "registry.k8s.io/pause:3.9" as the CRI sandbox image.
[certs] Using certificateDir folder "/etc/kubernetes/pki"
[certs] Generating "ca" certificate and key
[certs] Generating "apiserver" certificate and key
[certs] apiserver serving cert is signed for DNS names [kubernetes kubernetes.default kubernetes.default.svc kubernetes.default.svc.cluster.local master] and IPs [10.96.0.1 192.168.0.193]
[certs] Generating "apiserver-kubelet-client" certificate and key
[certs] Generating "front-proxy-ca" certificate and key
[certs] Generating "front-proxy-client" certificate and key
[certs] Generating "etcd/ca" certificate and key
[certs] Generating "etcd/server" certificate and key
[certs] etcd/server serving cert is signed for DNS names [localhost master] and IPs [192.168.0.193 127.0.0.1 ::1]
[certs] Generating "etcd/peer" certificate and key
[certs] etcd/peer serving cert is signed for DNS names [localhost master] and IPs [192.168.0.193 127.0.0.1 ::1]
[certs] Generating "etcd/healthcheck-client" certificate and key
[certs] Generating "apiserver-etcd-client" certificate and key
[certs] Generating "sa" key and public key
[kubeconfig] Using kubeconfig folder "/etc/kubernetes"
[kubeconfig] Writing "admin.conf" kubeconfig file
[kubeconfig] Writing "super-admin.conf" kubeconfig file
[kubeconfig] Writing "kubelet.conf" kubeconfig file
[kubeconfig] Writing "controller-manager.conf" kubeconfig file
[kubeconfig] Writing "scheduler.conf" kubeconfig file
[etcd] Creating static Pod manifest for local etcd in "/etc/kubernetes/manifests"
[control-plane] Using manifest folder "/etc/kubernetes/manifests"
[control-plane] Creating static Pod manifest for "kube-apiserver"
[control-plane] Creating static Pod manifest for "kube-controller-manager"
[control-plane] Creating static Pod manifest for "kube-scheduler"
[kubelet-start] Writing kubelet environment file with flags to file "/var/lib/kubelet/kubeadm-flags.env"
[kubelet-start] Writing kubelet configuration to file "/var/lib/kubelet/config.yaml"
[kubelet-start] Starting the kubelet
[wait-control-plane] Waiting for the kubelet to boot up the control plane as static Pods from directory "/etc/kubernetes/manifests"
[kubelet-check] Waiting for a healthy kubelet. This can take up to 4m0s
[kubelet-check] The kubelet is healthy after 1.006047964s
[api-check] Waiting for a healthy API server. This can take up to 4m0s
[api-check] The API server is healthy after 3.507299834s
[upload-config] Storing the configuration used in ConfigMap "kubeadm-config" in the "kube-system" Namespace
[kubelet] Creating a ConfigMap "kubelet-config" in namespace kube-system with the configuration for the kubelets in the cluster
[upload-certs] Skipping phase. Please see --upload-certs
[mark-control-plane] Marking the node master as control-plane by adding the labels: [node-role.kubernetes.io/control-plane node.kubernetes.io/exclude-from-external-load-balancers]
[mark-control-plane] Marking the node master as control-plane by adding the taints [node-role.kubernetes.io/control-plane:NoSchedule]
[bootstrap-token] Using token: ej7i8h.aa7roufjvhr9vvk7
[bootstrap-token] Configuring bootstrap tokens, cluster-info ConfigMap, RBAC Roles
[bootstrap-token] Configured RBAC rules to allow Node Bootstrap tokens to get nodes
[bootstrap-token] Configured RBAC rules to allow Node Bootstrap tokens to post CSRs in order for nodes to get long term certificate credentials
[bootstrap-token] Configured RBAC rules to allow the csrapprover controller automatically approve CSRs from a Node Bootstrap Token
[bootstrap-token] Configured RBAC rules to allow certificate rotation for all node client certificates in the cluster
[bootstrap-token] Creating the "cluster-info" ConfigMap in the "kube-public" namespace
[kubelet-finalize] Updating "/etc/kubernetes/kubelet.conf" to point to a rotatable kubelet client certificate and key
[addons] Applied essential addon: CoreDNS
[addons] Applied essential addon: kube-proxy

Your Kubernetes control-plane has initialized successfully!

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

kubeadm join 192.168.0.193:6443 --token ej7i8h.aa7roufjvhr9vvk7 \
	--discovery-token-ca-cert-hash sha256:37f427fe4248fe04102a8ba10afed9b60c4ac7594b60ca14674d0da42164933e 
master@master:~$ mkdir -p $HOME/.kube
master@master:~$ sudo cp -i /etc/kubernetes/admin.conf $HOME/.kube/config
cp: overwrite '/home/master/.kube/config'? 
master@master:~$ sudo chown $(id -u):$(id -g) $HOME/.kube/config
master@master:~$ export KUBECONFIG=/etc/kubernetes/admin.conf
master@master:~$ kubectl create -f custom-resources.yaml --validate=false
error: error loading config file "/etc/kubernetes/admin.conf": open /etc/kubernetes/admin.conf: permission denied
master@master:~$ sudo chmod -R 777 /etc/kubernetes/admin.conf
master@master:~$ kubectl create -f custom-resources.yaml --validate=false
resource mapping not found for name: "default" namespace: "" from "custom-resources.yaml": no matches for kind "Installation" in version "operator.tigera.io/v1"
ensure CRDs are installed first
resource mapping not found for name: "default" namespace: "" from "custom-resources.yaml": no matches for kind "APIServer" in version "operator.tigera.io/v1"
ensure CRDs are installed first
master@master:~$ kubectl create -f  --validate=false
.bash_history              .cache/                    .ssh/                      .wget-hsts                 kubectl.sha256             
.bash_logout               .kube/                     .sudo_as_admin_successful  custom-resources.yaml      tigera-operator.yaml       
.bashrc                    .profile                   .viminfo                   kubectl                    
master@master:~$ kubectl create -f tigera-operator.yaml --validate=false
namespace/tigera-operator created
customresourcedefinition.apiextensions.k8s.io/bgpconfigurations.crd.projectcalico.org created
customresourcedefinition.apiextensions.k8s.io/bgpfilters.crd.projectcalico.org created
customresourcedefinition.apiextensions.k8s.io/bgppeers.crd.projectcalico.org created
customresourcedefinition.apiextensions.k8s.io/blockaffinities.crd.projectcalico.org created
customresourcedefinition.apiextensions.k8s.io/caliconodestatuses.crd.projectcalico.org created
customresourcedefinition.apiextensions.k8s.io/clusterinformations.crd.projectcalico.org created
customresourcedefinition.apiextensions.k8s.io/felixconfigurations.crd.projectcalico.org created
customresourcedefinition.apiextensions.k8s.io/globalnetworkpolicies.crd.projectcalico.org created
customresourcedefinition.apiextensions.k8s.io/globalnetworksets.crd.projectcalico.org created
customresourcedefinition.apiextensions.k8s.io/hostendpoints.crd.projectcalico.org created
customresourcedefinition.apiextensions.k8s.io/ipamblocks.crd.projectcalico.org created
customresourcedefinition.apiextensions.k8s.io/ipamconfigs.crd.projectcalico.org created
customresourcedefinition.apiextensions.k8s.io/ipamhandles.crd.projectcalico.org created
customresourcedefinition.apiextensions.k8s.io/ippools.crd.projectcalico.org created
customresourcedefinition.apiextensions.k8s.io/ipreservations.crd.projectcalico.org created
customresourcedefinition.apiextensions.k8s.io/kubecontrollersconfigurations.crd.projectcalico.org created
customresourcedefinition.apiextensions.k8s.io/networkpolicies.crd.projectcalico.org created
customresourcedefinition.apiextensions.k8s.io/networksets.crd.projectcalico.org created
customresourcedefinition.apiextensions.k8s.io/apiservers.operator.tigera.io created
customresourcedefinition.apiextensions.k8s.io/imagesets.operator.tigera.io created
customresourcedefinition.apiextensions.k8s.io/installations.operator.tigera.io created
customresourcedefinition.apiextensions.k8s.io/tigerastatuses.operator.tigera.io created
serviceaccount/tigera-operator created
clusterrole.rbac.authorization.k8s.io/tigera-operator created
clusterrolebinding.rbac.authorization.k8s.io/tigera-operator created
deployment.apps/tigera-operator created
master@master:~$ kubectl cluster-info
Kubernetes control plane is running at https://192.168.0.193:6443
CoreDNS is running at https://192.168.0.193:6443/api/v1/namespaces/kube-system/services/kube-dns:dns/proxy

To further debug and diagnose cluster problems, use 'kubectl cluster-info dump'.
master@master:~$ 
```