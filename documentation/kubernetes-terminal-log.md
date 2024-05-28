```shell
master@master:~$ sudo kubeadm reset -f
[sudo] password for master: 
[reset] Reading configuration from the cluster...
[reset] FYI: You can look at this config file with 'kubectl -n kube-system get cm kubeadm-config -o yaml'
[preflight] Running pre-flight checks
[reset] Deleted contents of the etcd data directory: /var/lib/etcd
[reset] Stopping the kubelet service
[reset] Unmounting mounted directories in "/var/lib/kubelet"
W0526 17:29:12.518814  106466 cleanupnode.go:106] [reset] Failed to remove containers: [failed to stop running pod 0becebaa8faaa2401040e4fbc7711bdc847558c5cf13d7e4d4b1b24d7615d0e5: output: E0526 17:29:10.081171  107068 remote_runtime.go:222] "StopPodSandbox from runtime service failed" err="rpc error: code = Unknown desc = failed to destroy network for sandbox \"0becebaa8faaa2401040e4fbc7711bdc847558c5cf13d7e4d4b1b24d7615d0e5\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused" podSandboxID="0becebaa8faaa2401040e4fbc7711bdc847558c5cf13d7e4d4b1b24d7615d0e5"
time="2024-05-26T17:29:10Z" level=fatal msg="stopping the pod sandbox \"0becebaa8faaa2401040e4fbc7711bdc847558c5cf13d7e4d4b1b24d7615d0e5\": rpc error: code = Unknown desc = failed to destroy network for sandbox \"0becebaa8faaa2401040e4fbc7711bdc847558c5cf13d7e4d4b1b24d7615d0e5\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused"
: exit status 1, failed to stop running pod 36f4b7b93dd0b49bdc593c790a176ab65c7f8f48cf9b2684263d96b9f1217be9: output: E0526 17:29:10.378144  107209 remote_runtime.go:222] "StopPodSandbox from runtime service failed" err="rpc error: code = Unknown desc = failed to destroy network for sandbox \"36f4b7b93dd0b49bdc593c790a176ab65c7f8f48cf9b2684263d96b9f1217be9\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused" podSandboxID="36f4b7b93dd0b49bdc593c790a176ab65c7f8f48cf9b2684263d96b9f1217be9"
time="2024-05-26T17:29:10Z" level=fatal msg="stopping the pod sandbox \"36f4b7b93dd0b49bdc593c790a176ab65c7f8f48cf9b2684263d96b9f1217be9\": rpc error: code = Unknown desc = failed to destroy network for sandbox \"36f4b7b93dd0b49bdc593c790a176ab65c7f8f48cf9b2684263d96b9f1217be9\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused"
: exit status 1, failed to stop running pod 9adee702f255f47383da7f9503f7918200c74a488f92fd53f4e86e763c0345ae: output: E0526 17:29:10.677026  107350 remote_runtime.go:222] "StopPodSandbox from runtime service failed" err="rpc error: code = Unknown desc = failed to destroy network for sandbox \"9adee702f255f47383da7f9503f7918200c74a488f92fd53f4e86e763c0345ae\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused" podSandboxID="9adee702f255f47383da7f9503f7918200c74a488f92fd53f4e86e763c0345ae"
time="2024-05-26T17:29:10Z" level=fatal msg="stopping the pod sandbox \"9adee702f255f47383da7f9503f7918200c74a488f92fd53f4e86e763c0345ae\": rpc error: code = Unknown desc = failed to destroy network for sandbox \"9adee702f255f47383da7f9503f7918200c74a488f92fd53f4e86e763c0345ae\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused"
: exit status 1, failed to stop running pod 9b3ce8d96f8325e05272c4fda89d5c99b03805f9e8219fc0b40c4e2bb499876c: output: E0526 17:29:10.974535  107492 remote_runtime.go:222] "StopPodSandbox from runtime service failed" err="rpc error: code = Unknown desc = failed to destroy network for sandbox \"9b3ce8d96f8325e05272c4fda89d5c99b03805f9e8219fc0b40c4e2bb499876c\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused" podSandboxID="9b3ce8d96f8325e05272c4fda89d5c99b03805f9e8219fc0b40c4e2bb499876c"
time="2024-05-26T17:29:10Z" level=fatal msg="stopping the pod sandbox \"9b3ce8d96f8325e05272c4fda89d5c99b03805f9e8219fc0b40c4e2bb499876c\": rpc error: code = Unknown desc = failed to destroy network for sandbox \"9b3ce8d96f8325e05272c4fda89d5c99b03805f9e8219fc0b40c4e2bb499876c\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused"
: exit status 1, failed to stop running pod ca02d01f47f245ad471d8e44b7a687099a7c2a9d9b6160cf8f21164cf0eedd8d: output: E0526 17:29:11.610103  107708 remote_runtime.go:222] "StopPodSandbox from runtime service failed" err="rpc error: code = Unknown desc = failed to destroy network for sandbox \"ca02d01f47f245ad471d8e44b7a687099a7c2a9d9b6160cf8f21164cf0eedd8d\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused" podSandboxID="ca02d01f47f245ad471d8e44b7a687099a7c2a9d9b6160cf8f21164cf0eedd8d"
time="2024-05-26T17:29:11Z" level=fatal msg="stopping the pod sandbox \"ca02d01f47f245ad471d8e44b7a687099a7c2a9d9b6160cf8f21164cf0eedd8d\": rpc error: code = Unknown desc = failed to destroy network for sandbox \"ca02d01f47f245ad471d8e44b7a687099a7c2a9d9b6160cf8f21164cf0eedd8d\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused"
: exit status 1, failed to stop running pod f1c3d075676acd7df0d34d0e0e109ec28c34e6cb33928a4caf2b49dbdf215832: output: E0526 17:29:11.903388  107850 remote_runtime.go:222] "StopPodSandbox from runtime service failed" err="rpc error: code = Unknown desc = failed to destroy network for sandbox \"f1c3d075676acd7df0d34d0e0e109ec28c34e6cb33928a4caf2b49dbdf215832\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused" podSandboxID="f1c3d075676acd7df0d34d0e0e109ec28c34e6cb33928a4caf2b49dbdf215832"
time="2024-05-26T17:29:11Z" level=fatal msg="stopping the pod sandbox \"f1c3d075676acd7df0d34d0e0e109ec28c34e6cb33928a4caf2b49dbdf215832\": rpc error: code = Unknown desc = failed to destroy network for sandbox \"f1c3d075676acd7df0d34d0e0e109ec28c34e6cb33928a4caf2b49dbdf215832\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused"
: exit status 1, failed to stop running pod afbf027474ce936d348a89005f8c5a90afc6cbace89f235a959e93ede5b389e6: output: E0526 17:29:12.209807  107993 remote_runtime.go:222] "StopPodSandbox from runtime service failed" err="rpc error: code = Unknown desc = failed to destroy network for sandbox \"afbf027474ce936d348a89005f8c5a90afc6cbace89f235a959e93ede5b389e6\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused" podSandboxID="afbf027474ce936d348a89005f8c5a90afc6cbace89f235a959e93ede5b389e6"
time="2024-05-26T17:29:12Z" level=fatal msg="stopping the pod sandbox \"afbf027474ce936d348a89005f8c5a90afc6cbace89f235a959e93ede5b389e6\": rpc error: code = Unknown desc = failed to destroy network for sandbox \"afbf027474ce936d348a89005f8c5a90afc6cbace89f235a959e93ede5b389e6\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused"
: exit status 1, failed to stop running pod 42403ad2551131d8e92b689188ba50ce6a678e063575bd7e3e2356209b57e20f: output: E0526 17:29:12.516122  108137 remote_runtime.go:222] "StopPodSandbox from runtime service failed" err="rpc error: code = Unknown desc = failed to destroy network for sandbox \"42403ad2551131d8e92b689188ba50ce6a678e063575bd7e3e2356209b57e20f\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused" podSandboxID="42403ad2551131d8e92b689188ba50ce6a678e063575bd7e3e2356209b57e20f"
time="2024-05-26T17:29:12Z" level=fatal msg="stopping the pod sandbox \"42403ad2551131d8e92b689188ba50ce6a678e063575bd7e3e2356209b57e20f\": rpc error: code = Unknown desc = failed to destroy network for sandbox \"42403ad2551131d8e92b689188ba50ce6a678e063575bd7e3e2356209b57e20f\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused"
: exit status 1]
[reset] Deleting contents of directories: [/etc/kubernetes/manifests /var/lib/kubelet /etc/kubernetes/pki]
[reset] Deleting files: [/etc/kubernetes/admin.conf /etc/kubernetes/super-admin.conf /etc/kubernetes/kubelet.conf /etc/kubernetes/bootstrap-kubelet.conf /etc/kubernetes/controller-manager.conf /etc/kubernetes/scheduler.conf]

The reset process does not clean CNI configuration. To do so, you must remove /etc/cni/net.d

The reset process does not reset or clean up iptables rules or IPVS tables.
If you wish to reset iptables, you must do so manually by using the "iptables" command.

If your cluster was setup to utilize IPVS, run ipvsadm --clear (or similar)
to reset your system's IPVS tables.

The reset process does not clean your kubeconfig files and you must remove them manually.
Please, check the contents of the $HOME/.kube/config file.
master@master:~$ sudo kubeadm init --pod-network-cidr=192.168.0.0/16 --cri-socket=/var/run/containerd/containerd.sock --control-plane-endpoint=k8s-cluster.mehmet.com --v=5
W0526 17:29:41.888207  108168 initconfiguration.go:125] Usage of CRI endpoints without URL scheme is deprecated and can cause kubelet errors in the future. Automatically prepending scheme "unix" to the "criSocket" with value "/var/run/containerd/containerd.sock". Please update your configuration!
I0526 17:29:41.889178  108168 interface.go:432] Looking for default routes with IPv4 addresses
I0526 17:29:41.889193  108168 interface.go:437] Default route transits interface "ens33"
I0526 17:29:41.889363  108168 interface.go:209] Interface ens33 is up
I0526 17:29:41.889414  108168 interface.go:257] Interface "ens33" has 2 addresses :[192.168.0.193/24 fe80::20c:29ff:fe09:602d/64].
I0526 17:29:41.889425  108168 interface.go:224] Checking addr  192.168.0.193/24.
I0526 17:29:41.889432  108168 interface.go:231] IP found 192.168.0.193
I0526 17:29:41.889439  108168 interface.go:263] Found valid IPv4 address 192.168.0.193 for interface "ens33".
I0526 17:29:41.889445  108168 interface.go:443] Found active IP 192.168.0.193 
I0526 17:29:41.889472  108168 kubelet.go:196] the value of KubeletConfiguration.cgroupDriver is empty; setting it to "systemd"
I0526 17:29:41.896195  108168 version.go:187] fetching Kubernetes version from URL: https://dl.k8s.io/release/stable-1.txt
[init] Using Kubernetes version: v1.30.1
[preflight] Running pre-flight checks
I0526 17:29:44.685600  108168 checks.go:561] validating Kubernetes and kubeadm version
I0526 17:29:44.685809  108168 checks.go:166] validating if the firewall is enabled and active
I0526 17:29:44.736290  108168 checks.go:201] validating availability of port 6443
I0526 17:29:44.736716  108168 checks.go:201] validating availability of port 10259
I0526 17:29:44.736799  108168 checks.go:201] validating availability of port 10257
I0526 17:29:44.736923  108168 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-apiserver.yaml
I0526 17:29:44.736948  108168 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-controller-manager.yaml
I0526 17:29:44.736960  108168 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-scheduler.yaml
I0526 17:29:44.736971  108168 checks.go:278] validating the existence of file /etc/kubernetes/manifests/etcd.yaml
I0526 17:29:44.736982  108168 checks.go:428] validating if the connectivity type is via proxy or direct
I0526 17:29:44.737005  108168 checks.go:467] validating http connectivity to first IP address in the CIDR
I0526 17:29:44.737025  108168 checks.go:467] validating http connectivity to first IP address in the CIDR
I0526 17:29:44.737039  108168 checks.go:102] validating the container runtime
I0526 17:29:44.774634  108168 checks.go:637] validating whether swap is enabled or not
I0526 17:29:44.774751  108168 checks.go:368] validating the presence of executable crictl
I0526 17:29:44.774793  108168 checks.go:368] validating the presence of executable conntrack
I0526 17:29:44.774898  108168 checks.go:368] validating the presence of executable ip
I0526 17:29:44.774936  108168 checks.go:368] validating the presence of executable iptables
I0526 17:29:44.774961  108168 checks.go:368] validating the presence of executable mount
I0526 17:29:44.774989  108168 checks.go:368] validating the presence of executable nsenter
I0526 17:29:44.775020  108168 checks.go:368] validating the presence of executable ebtables
I0526 17:29:44.775057  108168 checks.go:368] validating the presence of executable ethtool
I0526 17:29:44.775080  108168 checks.go:368] validating the presence of executable socat
I0526 17:29:44.775128  108168 checks.go:368] validating the presence of executable tc
I0526 17:29:44.775156  108168 checks.go:368] validating the presence of executable touch
I0526 17:29:44.775192  108168 checks.go:514] running all checks
I0526 17:29:44.791532  108168 checks.go:399] checking whether the given node name is valid and reachable using net.LookupHost
I0526 17:29:44.791897  108168 checks.go:603] validating kubelet version
I0526 17:29:44.847488  108168 checks.go:128] validating if the "kubelet" service is enabled and active
I0526 17:29:44.985033  108168 checks.go:201] validating availability of port 10250
I0526 17:29:44.985327  108168 checks.go:327] validating the contents of file /proc/sys/net/ipv4/ip_forward
I0526 17:29:44.985536  108168 checks.go:201] validating availability of port 2379
I0526 17:29:44.985733  108168 checks.go:201] validating availability of port 2380
I0526 17:29:44.985923  108168 checks.go:241] validating the existence and emptiness of directory /var/lib/etcd
[preflight] Pulling images required for setting up a Kubernetes cluster
[preflight] This might take a minute or two, depending on the speed of your internet connection
[preflight] You can also perform this action in beforehand using 'kubeadm config images pull'
I0526 17:29:44.986417  108168 checks.go:830] using image pull policy: IfNotPresent
W0526 17:29:45.027824  108168 checks.go:844] detected that the sandbox image "registry.k8s.io/pause:3.6" of the container runtime is inconsistent with that used by kubeadm.It is recommended to use "registry.k8s.io/pause:3.9" as the CRI sandbox image.
I0526 17:29:45.053864  108168 checks.go:862] image exists: registry.k8s.io/kube-apiserver:v1.30.1
I0526 17:29:45.079117  108168 checks.go:862] image exists: registry.k8s.io/kube-controller-manager:v1.30.1
I0526 17:29:45.106130  108168 checks.go:862] image exists: registry.k8s.io/kube-scheduler:v1.30.1
I0526 17:29:45.131719  108168 checks.go:862] image exists: registry.k8s.io/kube-proxy:v1.30.1
I0526 17:29:45.161350  108168 checks.go:862] image exists: registry.k8s.io/coredns/coredns:v1.11.1
I0526 17:29:45.186868  108168 checks.go:862] image exists: registry.k8s.io/pause:3.9
I0526 17:29:45.213339  108168 checks.go:862] image exists: registry.k8s.io/etcd:3.5.12-0
[certs] Using certificateDir folder "/etc/kubernetes/pki"
I0526 17:29:45.213763  108168 certs.go:112] creating a new certificate authority for ca
[certs] Generating "ca" certificate and key
I0526 17:29:45.356146  108168 certs.go:483] validating certificate period for ca certificate
[certs] Generating "apiserver" certificate and key
[certs] apiserver serving cert is signed for DNS names [k8s-cluster.mehmet.com kubernetes kubernetes.default kubernetes.default.svc kubernetes.default.svc.cluster.local master] and IPs [10.96.0.1 192.168.0.193]
[certs] Generating "apiserver-kubelet-client" certificate and key
I0526 17:29:45.980006  108168 certs.go:112] creating a new certificate authority for front-proxy-ca
[certs] Generating "front-proxy-ca" certificate and key
I0526 17:29:46.065374  108168 certs.go:483] validating certificate period for front-proxy-ca certificate
[certs] Generating "front-proxy-client" certificate and key
I0526 17:29:46.254547  108168 certs.go:112] creating a new certificate authority for etcd-ca
[certs] Generating "etcd/ca" certificate and key
I0526 17:29:46.781053  108168 certs.go:483] validating certificate period for etcd/ca certificate
[certs] Generating "etcd/server" certificate and key
[certs] etcd/server serving cert is signed for DNS names [localhost master] and IPs [192.168.0.193 127.0.0.1 ::1]
[certs] Generating "etcd/peer" certificate and key
[certs] etcd/peer serving cert is signed for DNS names [localhost master] and IPs [192.168.0.193 127.0.0.1 ::1]
[certs] Generating "etcd/healthcheck-client" certificate and key
[certs] Generating "apiserver-etcd-client" certificate and key
I0526 17:29:47.474180  108168 certs.go:78] creating new public/private key files for signing service account users
[certs] Generating "sa" key and public key
[kubeconfig] Using kubeconfig folder "/etc/kubernetes"
I0526 17:29:47.695212  108168 kubeconfig.go:112] creating kubeconfig file for admin.conf
[kubeconfig] Writing "admin.conf" kubeconfig file
I0526 17:29:47.874534  108168 kubeconfig.go:112] creating kubeconfig file for super-admin.conf
[kubeconfig] Writing "super-admin.conf" kubeconfig file
I0526 17:29:47.985366  108168 kubeconfig.go:112] creating kubeconfig file for kubelet.conf
[kubeconfig] Writing "kubelet.conf" kubeconfig file
I0526 17:29:48.076826  108168 kubeconfig.go:112] creating kubeconfig file for controller-manager.conf
[kubeconfig] Writing "controller-manager.conf" kubeconfig file
I0526 17:29:48.301134  108168 kubeconfig.go:112] creating kubeconfig file for scheduler.conf
[kubeconfig] Writing "scheduler.conf" kubeconfig file
[etcd] Creating static Pod manifest for local etcd in "/etc/kubernetes/manifests"
I0526 17:29:48.509456  108168 local.go:65] [etcd] wrote Static Pod manifest for a local etcd member to "/etc/kubernetes/manifests/etcd.yaml"
[control-plane] Using manifest folder "/etc/kubernetes/manifests"
[control-plane] Creating static Pod manifest for "kube-apiserver"
I0526 17:29:48.509914  108168 manifests.go:103] [control-plane] getting StaticPodSpecs
I0526 17:29:48.510132  108168 certs.go:483] validating certificate period for CA certificate
I0526 17:29:48.510178  108168 manifests.go:129] [control-plane] adding volume "ca-certs" for component "kube-apiserver"
I0526 17:29:48.510184  108168 manifests.go:129] [control-plane] adding volume "etc-ca-certificates" for component "kube-apiserver"
I0526 17:29:48.510188  108168 manifests.go:129] [control-plane] adding volume "k8s-certs" for component "kube-apiserver"
I0526 17:29:48.510192  108168 manifests.go:129] [control-plane] adding volume "usr-local-share-ca-certificates" for component "kube-apiserver"
I0526 17:29:48.510196  108168 manifests.go:129] [control-plane] adding volume "usr-share-ca-certificates" for component "kube-apiserver"
I0526 17:29:48.510747  108168 manifests.go:158] [control-plane] wrote static Pod manifest for component "kube-apiserver" to "/etc/kubernetes/manifests/kube-apiserver.yaml"
[control-plane] Creating static Pod manifest for "kube-controller-manager"
I0526 17:29:48.510772  108168 manifests.go:103] [control-plane] getting StaticPodSpecs
I0526 17:29:48.510883  108168 manifests.go:129] [control-plane] adding volume "ca-certs" for component "kube-controller-manager"
I0526 17:29:48.510888  108168 manifests.go:129] [control-plane] adding volume "etc-ca-certificates" for component "kube-controller-manager"
I0526 17:29:48.510892  108168 manifests.go:129] [control-plane] adding volume "flexvolume-dir" for component "kube-controller-manager"
I0526 17:29:48.510896  108168 manifests.go:129] [control-plane] adding volume "k8s-certs" for component "kube-controller-manager"
I0526 17:29:48.510899  108168 manifests.go:129] [control-plane] adding volume "kubeconfig" for component "kube-controller-manager"
I0526 17:29:48.510902  108168 manifests.go:129] [control-plane] adding volume "usr-local-share-ca-certificates" for component "kube-controller-manager"
I0526 17:29:48.510905  108168 manifests.go:129] [control-plane] adding volume "usr-share-ca-certificates" for component "kube-controller-manager"
I0526 17:29:48.511452  108168 manifests.go:158] [control-plane] wrote static Pod manifest for component "kube-controller-manager" to "/etc/kubernetes/manifests/kube-controller-manager.yaml"
[control-plane] Creating static Pod manifest for "kube-scheduler"
I0526 17:29:48.511465  108168 manifests.go:103] [control-plane] getting StaticPodSpecs
I0526 17:29:48.511579  108168 manifests.go:129] [control-plane] adding volume "kubeconfig" for component "kube-scheduler"
I0526 17:29:48.512278  108168 manifests.go:158] [control-plane] wrote static Pod manifest for component "kube-scheduler" to "/etc/kubernetes/manifests/kube-scheduler.yaml"
I0526 17:29:48.512593  108168 kubelet.go:68] Stopping the kubelet
[kubelet-start] Writing kubelet environment file with flags to file "/var/lib/kubelet/kubeadm-flags.env"
[kubelet-start] Writing kubelet configuration to file "/var/lib/kubelet/config.yaml"
[kubelet-start] Starting the kubelet
[wait-control-plane] Waiting for the kubelet to boot up the control plane as static Pods from directory "/etc/kubernetes/manifests"
[kubelet-check] Waiting for a healthy kubelet. This can take up to 4m0s
[kubelet-check] The kubelet is healthy after 501.176868ms
[api-check] Waiting for a healthy API server. This can take up to 4m0s
[api-check] The API server is healthy after 10.501995206s
I0526 17:29:59.842489  108168 kubeconfig.go:608] ensuring that the ClusterRoleBinding for the kubeadm:cluster-admins Group exists
I0526 17:29:59.843881  108168 kubeconfig.go:681] creating the ClusterRoleBinding for the kubeadm:cluster-admins Group by using super-admin.conf
I0526 17:29:59.854039  108168 uploadconfig.go:112] [upload-config] Uploading the kubeadm ClusterConfiguration to a ConfigMap
[upload-config] Storing the configuration used in ConfigMap "kubeadm-config" in the "kube-system" Namespace
I0526 17:29:59.866375  108168 uploadconfig.go:126] [upload-config] Uploading the kubelet component config to a ConfigMap
[kubelet] Creating a ConfigMap "kubelet-config" in namespace kube-system with the configuration for the kubelets in the cluster
I0526 17:29:59.881840  108168 uploadconfig.go:131] [upload-config] Preserving the CRISocket information for the control-plane node
I0526 17:29:59.881899  108168 patchnode.go:31] [patchnode] Uploading the CRI Socket information "unix:///var/run/containerd/containerd.sock" to the Node API object "master" as an annotation
[upload-certs] Skipping phase. Please see --upload-certs
[mark-control-plane] Marking the node master as control-plane by adding the labels: [node-role.kubernetes.io/control-plane node.kubernetes.io/exclude-from-external-load-balancers]
[mark-control-plane] Marking the node master as control-plane by adding the taints [node-role.kubernetes.io/control-plane:NoSchedule]
[bootstrap-token] Using token: rmmwq6.8lencr3i8wcl7qtm
[bootstrap-token] Configuring bootstrap tokens, cluster-info ConfigMap, RBAC Roles
[bootstrap-token] Configured RBAC rules to allow Node Bootstrap tokens to get nodes
[bootstrap-token] Configured RBAC rules to allow Node Bootstrap tokens to post CSRs in order for nodes to get long term certificate credentials
[bootstrap-token] Configured RBAC rules to allow the csrapprover controller automatically approve CSRs from a Node Bootstrap Token
[bootstrap-token] Configured RBAC rules to allow certificate rotation for all node client certificates in the cluster
[bootstrap-token] Creating the "cluster-info" ConfigMap in the "kube-public" namespace
I0526 17:30:02.546596  108168 clusterinfo.go:47] [bootstrap-token] loading admin kubeconfig
I0526 17:30:02.547835  108168 clusterinfo.go:58] [bootstrap-token] copying the cluster from admin.conf to the bootstrap kubeconfig
I0526 17:30:02.548165  108168 clusterinfo.go:70] [bootstrap-token] creating/updating ConfigMap in kube-public namespace
I0526 17:30:02.552608  108168 clusterinfo.go:84] creating the RBAC rules for exposing the cluster-info ConfigMap in the kube-public namespace
I0526 17:30:02.567898  108168 kubeletfinalize.go:91] [kubelet-finalize] Assuming that kubelet client certificate rotation is enabled: found "/var/lib/kubelet/pki/kubelet-client-current.pem"
[kubelet-finalize] Updating "/etc/kubernetes/kubelet.conf" to point to a rotatable kubelet client certificate and key
I0526 17:30:02.569144  108168 kubeletfinalize.go:145] [kubelet-finalize] Restarting the kubelet to enable client certificate rotation
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

You can now join any number of control-plane nodes by copying certificate authorities
and service account keys on each node and then running the following as root:

  kubeadm join k8s-cluster.mehmet.com:6443 --token rmmwq6.8lencr3i8wcl7qtm \
	--discovery-token-ca-cert-hash sha256:d8eec579efa520c7fc5cf6318d266e708f5212bad77ca1953e604e45ef8eb0f8 \
	--control-plane 

Then you can join any number of worker nodes by running the following on each as root:

kubeadm join k8s-cluster.mehmet.com:6443 --token rmmwq6.8lencr3i8wcl7qtm \
	--discovery-token-ca-cert-hash sha256:d8eec579efa520c7fc5cf6318d266e708f5212bad77ca1953e604e45ef8eb0f8 
master@master:~$   mkdir -p $HOME/.kube
  sudo cp -i /etc/kubernetes/admin.conf $HOME/.kube/config
  sudo chown $(id -u):$(id -g) $HOME/.kube/config
cp: overwrite '/home/master/.kube/config'? 
master@master:~$ export KUBECONFIG=/etc/kubernetes/admin.conf
master@master:~$ sudo chmod -R 755 /etc/kubernetes/admin.conf
master@master:~$ kubectl create -f https://raw.githubusercontent.com/projectcalico/calico/v3.28.0/manifests/tigera-operator.yaml
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
master@master:~$ kubectl create -f https://raw.githubusercontent.com/projectcalico/calico/v3.28.0/manifests/custom-resources.yaml
installation.operator.tigera.io/default created
apiserver.operator.tigera.io/default created
master@master:~$ watch kubectl get pods -n calico-system
master@master:~$ watch kubectl get pods -n calico-system
master@master:~$ kubectl get nodes -o wide
NAME      STATUS   ROLES           AGE     VERSION   INTERNAL-IP     EXTERNAL-IP   OS-IMAGE           KERNEL-VERSION     CONTAINER-RUNTIME
master    Ready    control-plane   2m19s   v1.30.1   192.168.0.193   <none>        Ubuntu 24.04 LTS   6.8.0-31-generic   containerd://1.6.31
worker1   Ready    <none>          42s     v1.30.1   192.168.0.143   <none>        Ubuntu 24.04 LTS   6.8.0-31-generic   containerd://1.6.31
worker2   Ready    <none>          34s     v1.30.1   192.168.0.103   <none>        Ubuntu 24.04 LTS   6.8.0-31-generic   containerd://1.6.32
master@master:~$ kubectl apply -f hello-pod.yaml
pod/hello-pod created
master@master:~$ kubectl get pods -o wide
NAME        READY   STATUS    RESTARTS   AGE   IP               NODE      NOMINATED NODE   READINESS GATES
hello-pod   1/1     Running   0          37s   192.168.189.66   worker2   <none>           <none>
master@master:~$ helm repo add kubernetes-dashboard https://kubernetes.github.io/dashboard/
helm upgrade --install kubernetes-dashboard kubernetes-dashboard/kubernetes-dashboard --create-namespace --namespace kubernetes-dashboard
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
"kubernetes-dashboard" already exists with the same configuration, skipping
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
Release "kubernetes-dashboard" does not exist. Installing it now.
NAME: kubernetes-dashboard
LAST DEPLOYED: Sun May 26 17:34:32 2024
NAMESPACE: kubernetes-dashboard
STATUS: deployed
REVISION: 1
TEST SUITE: None
NOTES:
*************************************************************************************************
*** PLEASE BE PATIENT: Kubernetes Dashboard may need a few minutes to get up and become ready ***
*************************************************************************************************

Congratulations! You have just installed Kubernetes Dashboard in your cluster.

To access Dashboard run:
  kubectl -n kubernetes-dashboard port-forward svc/kubernetes-dashboard-kong-proxy 8443:443

NOTE: In case port-forward command does not work, make sure that kong service name is correct.
      Check the services in Kubernetes Dashboard namespace using:
        kubectl -n kubernetes-dashboard get svc

Dashboard will be available at:
  https://localhost:8443
master@master:~$ kubectl -n kubernetes-dashboard get svc -o wide
NAME                                   TYPE        CLUSTER-IP       EXTERNAL-IP   PORT(S)                         AGE   SELECTOR
kubernetes-dashboard-api               ClusterIP   10.104.173.50    <none>        8000/TCP                        11s   app.kubernetes.io/instance=kubernetes-dashboard,app.kubernetes.io/name=kubernetes-dashboard-api,app.kubernetes.io/part-of=kubernetes-dashboard
kubernetes-dashboard-auth              ClusterIP   10.107.220.132   <none>        8000/TCP                        11s   app.kubernetes.io/instance=kubernetes-dashboard,app.kubernetes.io/name=kubernetes-dashboard-auth,app.kubernetes.io/part-of=kubernetes-dashboard
kubernetes-dashboard-kong-manager      NodePort    10.105.183.61    <none>        8002:32635/TCP,8445:32608/TCP   11s   app.kubernetes.io/component=app,app.kubernetes.io/instance=kubernetes-dashboard,app.kubernetes.io/name=kong
kubernetes-dashboard-kong-proxy        ClusterIP   10.109.79.74     <none>        443/TCP                         11s   app.kubernetes.io/component=app,app.kubernetes.io/instance=kubernetes-dashboard,app.kubernetes.io/name=kong
kubernetes-dashboard-metrics-scraper   ClusterIP   10.101.33.245    <none>        8000/TCP                        11s   app.kubernetes.io/instance=kubernetes-dashboard,app.kubernetes.io/name=kubernetes-dashboard-metrics-scraper,app.kubernetes.io/part-of=kubernetes-dashboard
kubernetes-dashboard-web               ClusterIP   10.100.99.126    <none>        8000/TCP                        11s   app.kubernetes.io/instance=kubernetes-dashboard,app.kubernetes.io/name=kubernetes-dashboard-web,app.kubernetes.io/part-of=kubernetes-dashboard
master@master:~$ screen -S kubernetes-dashboard
[detached from 112619.kubernetes-dashboard]
master@master:~$ screen -ls
There is a screen on:
	112619.kubernetes-dashboard	(05/26/24 17:34:59)	(Detached)
1 Socket in /run/screen/S-master.
master@master:~$ kubectl apply -f dashboard-adminuser.yaml
serviceaccount/admin-user created
master@master:~$ kubectl apply -f cluster-role.yaml
clusterrolebinding.rbac.authorization.k8s.io/admin-user created
master@master:~$ kubectl -n kubernetes-dashboard create token admin-user
eyJhbGciOiJSUzI1NiIsImtpZCI6InlkLS01ZHdPb2pobEU5TFl1UlhHSFozS3NCc0tnb1RaMUtaenFOcDNyRWsifQ.eyJhdWQiOlsiaHR0cHM6Ly9rdWJlcm5ldGVzLmRlZmF1bHQuc3ZjLmNsdXN0ZXIubG9jYWwiXSwiZXhwIjoxNzE2NzQ4Njc5LCJpYXQiOjE3MTY3NDUwNzksImlzcyI6Imh0dHBzOi8va3ViZXJuZXRlcy5kZWZhdWx0LnN2Yy5jbHVzdGVyLmxvY2FsIiwianRpIjoiNDIzNTVjMjUtMWViZi00NDc5LTkyNzctODUzYWU3MmUyMWRhIiwia3ViZXJuZXRlcy5pbyI6eyJuYW1lc3BhY2UiOiJrdWJlcm5ldGVzLWRhc2hib2FyZCIsInNlcnZpY2VhY2NvdW50Ijp7Im5hbWUiOiJhZG1pbi11c2VyIiwidWlkIjoiM2JhZDk3MGItZTNiOS00NmI2LWIxMjItNWJiY2U4ODc2NDRkIn19LCJuYmYiOjE3MTY3NDUwNzksInN1YiI6InN5c3RlbTpzZXJ2aWNlYWNjb3VudDprdWJlcm5ldGVzLWRhc2hib2FyZDphZG1pbi11c2VyIn0.b8NBktx6NppJoTU8R3jMg3e3ORyUWJlM0gaqs_fAm9EJvhtknu3evNGTQHQMSEBsUCvH5_cGSMeQZZYvPhRTSuwHtgioN-tXLLw5XVHffIozi-5XbyzTp3Owm31FatQZ1liV51eb0sIUqzZZvX5w5X8ppO6Kv2NOpzoCawgMkPngbr855qJjWwP-TFjEujg6DQARMXMhxkultOwAzRvO6hXtcbTW3daHg_RB8XFMjURrhYp9IayaqqpJ4jb0T1LI0VaTXgsuLJBl6MWiqnBEyroa4UTo_mFgzI5BM5TrzDR0bUOafTXkuYLMnleCZOh3-Z5f_jktC415x0N9XWa1ww
master@master:~$ kubectl apply --server-side -f manifests/setup
error: the path "manifests/setup" does not exist
master@master:~$ helm repo add prometheus-community https://prometheus-community.github.io/helm-charts
helm repo update
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
"prometheus-community" has been added to your repositories
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
Hang tight while we grab the latest from your chart repositories...
...Successfully got an update from the "metrics-server" chart repository
...Successfully got an update from the "kubernetes-dashboard" chart repository
...Successfully got an update from the "prometheus-community" chart repository
Update Complete. ⎈Happy Helming!⎈
master@master:~$ helm upgrade [RELEASE_NAME] prometheus-community/kube-prometheus-stack
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
Error: UPGRADE FAILED: release name is invalid: [RELEASE_NAME]
master@master:~$ helm search repo prometheus-community
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
NAME                                              	CHART VERSION	APP VERSION	DESCRIPTION                                       
prometheus-community/alertmanager                 	1.11.0       	v0.27.0    	The Alertmanager handles alerts sent by client ...
prometheus-community/alertmanager-snmp-notifier   	0.3.0        	v1.5.0     	The SNMP Notifier handles alerts coming from Pr...
prometheus-community/jiralert                     	1.7.1        	v1.3.0     	A Helm chart for Kubernetes to install jiralert   
prometheus-community/kube-prometheus-stack        	58.7.2       	v0.73.2    	kube-prometheus-stack collects Kubernetes manif...
prometheus-community/kube-state-metrics           	5.19.0       	2.12.0     	Install kube-state-metrics to generate and expo...
prometheus-community/prom-label-proxy             	0.7.2        	v0.8.1     	A proxy that enforces a given label in a given ...
prometheus-community/prometheus                   	25.21.0      	v2.52.0    	Prometheus is a monitoring system and time seri...
prometheus-community/prometheus-adapter           	4.10.0       	v0.11.2    	A Helm chart for k8s prometheus adapter           
prometheus-community/prometheus-blackbox-exporter 	8.17.0       	v0.25.0    	Prometheus Blackbox Exporter                      
prometheus-community/prometheus-cloudwatch-expo...	0.25.3       	0.15.5     	A Helm chart for prometheus cloudwatch-exporter   
prometheus-community/prometheus-conntrack-stats...	0.5.10       	v0.4.18    	A Helm chart for conntrack-stats-exporter         
prometheus-community/prometheus-consul-exporter   	1.0.0        	0.4.0      	A Helm chart for the Prometheus Consul Exporter   
prometheus-community/prometheus-couchdb-exporter  	1.0.0        	1.0        	A Helm chart to export the metrics from couchdb...
prometheus-community/prometheus-druid-exporter    	1.1.0        	v0.11.0    	Druid exporter to monitor druid metrics with Pr...
prometheus-community/prometheus-elasticsearch-e...	5.8.0        	v1.7.0     	Elasticsearch stats exporter for Prometheus       
prometheus-community/prometheus-fastly-exporter   	0.3.0        	v7.6.1     	A Helm chart for the Prometheus Fastly Exporter   
prometheus-community/prometheus-ipmi-exporter     	0.3.0        	v1.8.0     	This is an IPMI exporter for Prometheus.          
prometheus-community/prometheus-json-exporter     	0.11.0       	v0.6.0     	Install prometheus-json-exporter                  
prometheus-community/prometheus-kafka-exporter    	2.10.0       	v1.7.0     	A Helm chart to export the metrics from Kafka i...
prometheus-community/prometheus-memcached-exporter	0.3.2        	v0.14.3    	Prometheus exporter for Memcached metrics         
prometheus-community/prometheus-modbus-exporter   	0.1.2        	0.4.1      	A Helm chart for prometheus-modbus-exporter       
prometheus-community/prometheus-mongodb-exporter  	3.5.0        	0.40.0     	A Prometheus exporter for MongoDB metrics         
prometheus-community/prometheus-mysql-exporter    	2.5.3        	v0.15.1    	A Helm chart for prometheus mysql exporter with...
prometheus-community/prometheus-nats-exporter     	2.17.0       	0.15.0     	A Helm chart for prometheus-nats-exporter         
prometheus-community/prometheus-nginx-exporter    	0.2.1        	0.11.0     	A Helm chart for the Prometheus NGINX Exporter    
prometheus-community/prometheus-node-exporter     	4.34.0       	1.8.0      	A Helm chart for prometheus node-exporter         
prometheus-community/prometheus-opencost-exporter 	0.1.1        	1.108.0    	Prometheus OpenCost Exporter                      
prometheus-community/prometheus-operator          	9.3.2        	0.38.1     	DEPRECATED - This chart will be renamed. See ht...
prometheus-community/prometheus-operator-admiss...	0.12.0       	0.73.0     	Prometheus Operator Admission Webhook             
prometheus-community/prometheus-operator-crds     	11.0.0       	v0.73.0    	A Helm chart that collects custom resource defi...
prometheus-community/prometheus-pgbouncer-exporter	0.3.0        	v0.8.0     	A Helm chart for prometheus pgbouncer-exporter    
prometheus-community/prometheus-pingdom-exporter  	2.5.0        	20190610-1 	A Helm chart for Prometheus Pingdom Exporter      
prometheus-community/prometheus-pingmesh-exporter 	0.4.0        	v1.2.1     	Prometheus Pingmesh Exporter                      
prometheus-community/prometheus-postgres-exporter 	6.0.0        	v0.15.0    	A Helm chart for prometheus postgres-exporter     
prometheus-community/prometheus-pushgateway       	2.12.0       	v1.8.0     	A Helm chart for prometheus pushgateway           
prometheus-community/prometheus-rabbitmq-exporter 	1.11.0       	v0.29.0    	Rabbitmq metrics exporter for prometheus          
prometheus-community/prometheus-redis-exporter    	6.2.0        	v1.58.0    	Prometheus exporter for Redis metrics             
prometheus-community/prometheus-smartctl-exporter 	0.8.0        	v0.12.0    	A Helm chart for Kubernetes                       
prometheus-community/prometheus-snmp-exporter     	5.4.0        	v0.26.0    	Prometheus SNMP Exporter                          
prometheus-community/prometheus-sql-exporter      	0.1.0        	v0.5.4     	Prometheus SQL Exporter                           
prometheus-community/prometheus-stackdriver-exp...	4.5.0        	v0.15.0    	Stackdriver exporter for Prometheus               
prometheus-community/prometheus-statsd-exporter   	0.13.1       	v0.26.1    	A Helm chart for prometheus stats-exporter        
prometheus-community/prometheus-systemd-exporter  	0.2.2        	0.6.0      	A Helm chart for prometheus systemd-exporter      
prometheus-community/prometheus-to-sd             	0.4.2        	0.5.2      	Scrape metrics stored in prometheus format and ...
prometheus-community/prometheus-windows-exporter  	0.3.1        	0.25.1     	A Helm chart for prometheus windows-exporter      
master@master:~$ helm install kube-prometheus-stack prometheus-community/kube-prometheus-stack
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
^CRelease kube-prometheus-stack has been cancelled.
Error: INSTALLATION FAILED: context canceled
master@master:~$ ^C
master@master:~$ ^C
master@master:~$ ^C
master@master:~$ ^C
master@master:~$ helm install kube-prometheus-stack-58.7.2 prometheus-community/kube-prometheus-stack
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
W0526 18:01:41.589573  116680 warnings.go:70] metadata.name: this is used in Pod names and hostnames, which can result in surprising behavior; a DNS label is recommended: [must not contain dots]
Error: INSTALLATION FAILED: failed pre-install: 1 error occurred:
	* timed out waiting for the condition


master@master:~$ helm install kube-prometheus-stack-58.7.2 prometheus-community/kube-prometheus-stack
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
Error: INSTALLATION FAILED: cannot re-use a name that is still in use
master@master:~$ helm uninstall kube-prometheus-stack-58.7.2
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
release "kube-prometheus-stack-58.7.2" uninstalled
master@master:~$ helm install kube-prometheus-stack-58.7.2 prometheus-community/kube-prometheus-stack
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
W0526 18:15:46.904129  118863 warnings.go:70] metadata.name: this is used in Pod names and hostnames, which can result in surprising behavior; a DNS label is recommended: [must not contain dots]
Error: INSTALLATION FAILED: failed pre-install: 1 error occurred:
	* timed out waiting for the condition


master@master:~$ helm install kube-prometheus-stack-58.7.2 prometheus-community/kube-prometheus-stack
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
Error: INSTALLATION FAILED: cannot re-use a name that is still in use
master@master:~$ kubectl get nodes
NAME      STATUS   ROLES           AGE   VERSION
master    Ready    control-plane   52m   v1.30.1
worker1   Ready    <none>          50m   v1.30.1
worker2   Ready    <none>          50m   v1.30.1
master@master:~$ kubectl get pods -A
kubectl get svc -A
NAMESPACE              NAME                                                    READY   STATUS         RESTARTS   AGE
calico-apiserver       calico-apiserver-7864695cfb-7w4l2                       1/1     Running        0          50m
calico-apiserver       calico-apiserver-7864695cfb-vl87n                       1/1     Running        0          50m
calico-system          calico-kube-controllers-8464c8bfdc-9kttw                1/1     Running        0          51m
calico-system          calico-node-kpr97                                       1/1     Running        0          50m
calico-system          calico-node-pdn7m                                       1/1     Running        0          50m
calico-system          calico-node-tfnrd                                       1/1     Running        0          51m
calico-system          calico-typha-57766f9846-bh62d                           1/1     Running        0          51m
calico-system          calico-typha-57766f9846-x5vmt                           1/1     Running        0          50m
calico-system          csi-node-driver-2dldj                                   2/2     Running        0          51m
calico-system          csi-node-driver-hjptv                                   2/2     Running        0          50m
calico-system          csi-node-driver-rvdv9                                   2/2     Running        0          50m
default                hello-pod                                               1/1     Running        0          49m
default                kube-prometheus-stack-58.7-admission-create-ltkmd       0/1     Terminating    0          20m
default                kube-prometheus-stack-58.7-admission-create-lwv6n       0/1     Completed      0          6m30s
default                kube-prometheus-stack-admission-create-pb5f4            0/1     ErrImagePull   0          22m
kube-system            coredns-7db6d8ff4d-glctn                                1/1     Running        0          52m
kube-system            coredns-7db6d8ff4d-qwfgv                                1/1     Running        0          52m
kube-system            etcd-master                                             1/1     Running        48         52m
kube-system            kube-apiserver-master                                   1/1     Running        51         52m
kube-system            kube-controller-manager-master                          1/1     Running        47         52m
kube-system            kube-proxy-28k7p                                        1/1     Running        0          50m
kube-system            kube-proxy-4ctcw                                        1/1     Running        0          52m
kube-system            kube-proxy-6cfds                                        1/1     Running        0          50m
kube-system            kube-scheduler-master                                   1/1     Running        51         52m
kubernetes-dashboard   kubernetes-dashboard-api-646c7899d6-6vjp6               1/1     Running        0          47m
kubernetes-dashboard   kubernetes-dashboard-auth-849bc555f4-mxjp7              1/1     Running        0          47m
kubernetes-dashboard   kubernetes-dashboard-kong-7696bb8c88-z9tnk              1/1     Running        0          47m
kubernetes-dashboard   kubernetes-dashboard-metrics-scraper-69cf85488f-b87x5   1/1     Running        0          47m
kubernetes-dashboard   kubernetes-dashboard-web-54bbdf8d84-4tz6l               1/1     Running        0          47m
tigera-operator        tigera-operator-76ff79f7fd-2gljh                        1/1     Running        0          51m
NAMESPACE              NAME                                   TYPE        CLUSTER-IP       EXTERNAL-IP   PORT(S)                         AGE
calico-apiserver       calico-api                             ClusterIP   10.111.52.99     <none>        443/TCP                         50m
calico-system          calico-kube-controllers-metrics        ClusterIP   None             <none>        9094/TCP                        50m
calico-system          calico-typha                           ClusterIP   10.107.78.81     <none>        5473/TCP                        51m
default                kubernetes                             ClusterIP   10.96.0.1        <none>        443/TCP                         52m
kube-system            kube-dns                               ClusterIP   10.96.0.10       <none>        53/UDP,53/TCP,9153/TCP          52m
kubernetes-dashboard   kubernetes-dashboard-api               ClusterIP   10.104.173.50    <none>        8000/TCP                        47m
kubernetes-dashboard   kubernetes-dashboard-auth              ClusterIP   10.107.220.132   <none>        8000/TCP                        47m
kubernetes-dashboard   kubernetes-dashboard-kong-manager      NodePort    10.105.183.61    <none>        8002:32635/TCP,8445:32608/TCP   47m
kubernetes-dashboard   kubernetes-dashboard-kong-proxy        ClusterIP   10.109.79.74     <none>        443/TCP                         47m
kubernetes-dashboard   kubernetes-dashboard-metrics-scraper   ClusterIP   10.101.33.245    <none>        8000/TCP                        47m
kubernetes-dashboard   kubernetes-dashboard-web               ClusterIP   10.100.99.126    <none>        8000/TCP                        47m
master@master:~$ kubectl describe quota
kubectl describe limitrange
No resources found in default namespace.
No resources found in default namespace.
master@master:~$ kubectl describe quota
No resources found in default namespace.
master@master:~$ helm install kube-prometheus-stack-latest prometheus-community/kube-prometheus-stack -n <namespace> --create-namespace
-bash: namespace: No such file or directory
master@master:~$ helm install kube-prometheus-stack-58.7.2 prometheus-community/kube-prometheus-stack
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
Error: INSTALLATION FAILED: cannot re-use a name that is still in use
master@master:~$ helm uninstall kube-prometheus-stack-58.7.2
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
release "kube-prometheus-stack-58.7.2" uninstalled
master@master:~$ helm install kube-prometheus-stack-58.7.2 prometheus-community/kube-prometheus-stack
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
W0526 18:24:10.087460  120204 warnings.go:70] metadata.name: this is used in Pod names and hostnames, which can result in surprising behavior; a DNS label is recommended: [must not contain dots]
W0526 18:24:13.716995  120204 warnings.go:70] metadata.name: this is used in Pod names and hostnames, which can result in surprising behavior; a DNS label is recommended: [must not contain dots]
W0526 18:24:13.719949  120204 warnings.go:70] metadata.name: this is used in Pod names and hostnames, which can result in surprising behavior; a DNS label is recommended: [must not contain dots]
W0526 18:24:13.720209  120204 warnings.go:70] metadata.name: this is used in Pod names and hostnames, which can result in surprising behavior; a DNS label is recommended: [must not contain dots]
Error: INSTALLATION FAILED: 11 errors occurred:
	* Service "kube-prometheus-stack-58.7-kube-proxy" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7-kube-proxy": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')
	* Service "kube-prometheus-stack-58.7-coredns" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7-coredns": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')
	* Service "kube-prometheus-stack-58.7-kube-scheduler" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7-kube-scheduler": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')
	* Service "kube-prometheus-stack-58.7-kube-controller-manager" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7-kube-controller-manager": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')
	* Service "kube-prometheus-stack-58.7-kube-etcd" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7-kube-etcd": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')
	* Service "kube-prometheus-stack-58.7-operator" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7-operator": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')
	* Service "kube-prometheus-stack-58.7.2-kube-state-metrics" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7.2-kube-state-metrics": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')
	* Service "kube-prometheus-stack-58.7.2-grafana" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7.2-grafana": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')
	* Service "kube-prometheus-stack-58.7-alertmanager" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7-alertmanager": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')
	* Service "kube-prometheus-stack-58.7-prometheus" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7-prometheus": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')
	* Service "kube-prometheus-stack-58.7.2-prometheus-node-exporter" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7.2-prometheus-node-exporter": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')


master@master:~$ helm install kube-prometheus-stack-58.7.2 prometheus-community/kube-prometheus-stack --timeout 10m0s
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
Error: INSTALLATION FAILED: cannot re-use a name that is still in use
master@master:~$ helm uninstall kube-prometheus-stack-58.7.2
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
release "kube-prometheus-stack-58.7.2" uninstalled
master@master:~$ helm install kube-prometheus-stack-58.7.2 prometheus-community/kube-prometheus-stack --timeout 10m0s
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
W0526 18:26:00.499879  120638 warnings.go:70] metadata.name: this is used in Pod names and hostnames, which can result in surprising behavior; a DNS label is recommended: [must not contain dots]
W0526 18:26:04.368011  120638 warnings.go:70] metadata.name: this is used in Pod names and hostnames, which can result in surprising behavior; a DNS label is recommended: [must not contain dots]
W0526 18:26:04.373352  120638 warnings.go:70] metadata.name: this is used in Pod names and hostnames, which can result in surprising behavior; a DNS label is recommended: [must not contain dots]
W0526 18:26:04.377375  120638 warnings.go:70] metadata.name: this is used in Pod names and hostnames, which can result in surprising behavior; a DNS label is recommended: [must not contain dots]
Error: INSTALLATION FAILED: 11 errors occurred:
	* Service "kube-prometheus-stack-58.7-kube-etcd" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7-kube-etcd": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')
	* Service "kube-prometheus-stack-58.7-coredns" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7-coredns": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')
	* Service "kube-prometheus-stack-58.7-kube-scheduler" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7-kube-scheduler": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')
	* Service "kube-prometheus-stack-58.7-kube-controller-manager" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7-kube-controller-manager": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')
	* Service "kube-prometheus-stack-58.7-kube-proxy" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7-kube-proxy": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')
	* Service "kube-prometheus-stack-58.7.2-grafana" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7.2-grafana": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')
	* Service "kube-prometheus-stack-58.7.2-prometheus-node-exporter" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7.2-prometheus-node-exporter": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')
	* Service "kube-prometheus-stack-58.7.2-kube-state-metrics" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7.2-kube-state-metrics": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')
	* Service "kube-prometheus-stack-58.7-alertmanager" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7-alertmanager": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')
	* Service "kube-prometheus-stack-58.7-prometheus" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7-prometheus": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')
	* Service "kube-prometheus-stack-58.7-operator" is invalid: metadata.name: Invalid value: "kube-prometheus-stack-58.7-operator": a DNS-1035 label must consist of lower case alphanumeric characters or '-', start with an alphabetic character, and end with an alphanumeric character (e.g. 'my-name',  or 'abc-123', regex used for validation is '[a-z]([-a-z0-9]*[a-z0-9])?')


master@master:~$ helm install kube-prometheus-stack-58 prometheus-community/kube-prometheus-stack --timeout 10m0s
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
NAME: kube-prometheus-stack-58
LAST DEPLOYED: Sun May 26 18:27:14 2024
NAMESPACE: default
STATUS: deployed
REVISION: 1
NOTES:
kube-prometheus-stack has been installed. Check its status by running:
  kubectl --namespace default get pods -l "release=kube-prometheus-stack-58"

Visit https://github.com/prometheus-operator/kube-prometheus for instructions on how to create & configure Alertmanager and Prometheus instances using the Operator.
master@master:~$ kubectl --namespace default get pods -l "release=kube-prometheus-stack-58"
NAME                                                           READY   STATUS              RESTARTS   AGE
kube-prometheus-stack-58-kube-state-metrics-7567d9979b-lh59z   0/1     ContainerCreating   0          2m45s
kube-prometheus-stack-58-operator-9b94b94dd-znr56              1/1     Running             0          2m46s
kube-prometheus-stack-58-prometheus-node-exporter-29w6q        0/1     Pending             0          2m46s
kube-prometheus-stack-58-prometheus-node-exporter-ddg8f        0/1     Pending             0          2m46s
kube-prometheus-stack-58-prometheus-node-exporter-ph9xn        0/1     Pending             0          2m46s
master@master:~$ kubectl --namespace default get pods -l "release=kube-prometheus-stack-58"
NAME                                                           READY   STATUS    RESTARTS   AGE
kube-prometheus-stack-58-kube-state-metrics-7567d9979b-lh59z   1/1     Running   0          4m57s
kube-prometheus-stack-58-operator-9b94b94dd-znr56              1/1     Running   0          4m58s
kube-prometheus-stack-58-prometheus-node-exporter-29w6q        0/1     Pending   0          4m58s
kube-prometheus-stack-58-prometheus-node-exporter-ddg8f        0/1     Pending   0          4m58s
kube-prometheus-stack-58-prometheus-node-exporter-ph9xn        0/1     Pending   0          4m58s
master@master:~$ kubectl --namespace default get pods -l "release=kube-prometheus-stack-58"
NAME                                                           READY   STATUS    RESTARTS   AGE
kube-prometheus-stack-58-kube-state-metrics-7567d9979b-lh59z   1/1     Running   0          5m8s
kube-prometheus-stack-58-operator-9b94b94dd-znr56              1/1     Running   0          5m9s
kube-prometheus-stack-58-prometheus-node-exporter-29w6q        0/1     Pending   0          5m9s
kube-prometheus-stack-58-prometheus-node-exporter-ddg8f        0/1     Pending   0          5m9s
kube-prometheus-stack-58-prometheus-node-exporter-ph9xn        0/1     Pending   0          5m9s
master@master:~$ kubectl --namespace default get pods -l "release=kube-prometheus-stack-58"
NAME                                                           READY   STATUS    RESTARTS   AGE
kube-prometheus-stack-58-kube-state-metrics-7567d9979b-lh59z   1/1     Running   0          5m9s
kube-prometheus-stack-58-operator-9b94b94dd-znr56              1/1     Running   0          5m10s
kube-prometheus-stack-58-prometheus-node-exporter-29w6q        0/1     Pending   0          5m10s
kube-prometheus-stack-58-prometheus-node-exporter-ddg8f        0/1     Pending   0          5m10s
kube-prometheus-stack-58-prometheus-node-exporter-ph9xn        0/1     Pending   0          5m10s
master@master:~$ kubectl --namespace default get pods -l "release=kube-prometheus-stack-58"
NAME                                                           READY   STATUS    RESTARTS   AGE
kube-prometheus-stack-58-kube-state-metrics-7567d9979b-lh59z   1/1     Running   0          5m10s
kube-prometheus-stack-58-operator-9b94b94dd-znr56              1/1     Running   0          5m11s
kube-prometheus-stack-58-prometheus-node-exporter-29w6q        0/1     Pending   0          5m11s
kube-prometheus-stack-58-prometheus-node-exporter-ddg8f        0/1     Pending   0          5m11s
kube-prometheus-stack-58-prometheus-node-exporter-ph9xn        0/1     Pending   0          5m11s
master@master:~$ kubectl --namespace default get pods -l "release=kube-prometheus-stack-58"
NAME                                                           READY   STATUS    RESTARTS   AGE
kube-prometheus-stack-58-kube-state-metrics-7567d9979b-lh59z   1/1     Running   0          5m11s
kube-prometheus-stack-58-operator-9b94b94dd-znr56              1/1     Running   0          5m12s
kube-prometheus-stack-58-prometheus-node-exporter-29w6q        0/1     Pending   0          5m12s
kube-prometheus-stack-58-prometheus-node-exporter-ddg8f        0/1     Pending   0          5m12s
kube-prometheus-stack-58-prometheus-node-exporter-ph9xn        0/1     Pending   0          5m12s
master@master:~$ kubectl --namespace default get pods -l "release=kube-prometheus-stack-58"
NAME                                                           READY   STATUS    RESTARTS   AGE
kube-prometheus-stack-58-kube-state-metrics-7567d9979b-lh59z   1/1     Running   0          6m19s
kube-prometheus-stack-58-operator-9b94b94dd-znr56              1/1     Running   0          6m20s
kube-prometheus-stack-58-prometheus-node-exporter-29w6q        0/1     Pending   0          6m20s
kube-prometheus-stack-58-prometheus-node-exporter-ddg8f        0/1     Pending   0          6m20s
kube-prometheus-stack-58-prometheus-node-exporter-ph9xn        0/1     Pending   0          6m20s
master@master:~$ kubectl --namespace default get pods -l "release=kube-prometheus-stack-58"
NAME                                                           READY   STATUS    RESTARTS   AGE
kube-prometheus-stack-58-kube-state-metrics-7567d9979b-lh59z   1/1     Running   0          6m21s
kube-prometheus-stack-58-operator-9b94b94dd-znr56              1/1     Running   0          6m22s
kube-prometheus-stack-58-prometheus-node-exporter-29w6q        0/1     Pending   0          6m22s
kube-prometheus-stack-58-prometheus-node-exporter-ddg8f        0/1     Pending   0          6m22s
kube-prometheus-stack-58-prometheus-node-exporter-ph9xn        0/1     Pending   0          6m22s
master@master:~$ kubectl --namespace default get pods -l "release=kube-prometheus-stack-58"
NAME                                                           READY   STATUS    RESTARTS   AGE
kube-prometheus-stack-58-kube-state-metrics-7567d9979b-lh59z   1/1     Running   0          6m22s
kube-prometheus-stack-58-operator-9b94b94dd-znr56              1/1     Running   0          6m23s
kube-prometheus-stack-58-prometheus-node-exporter-29w6q        0/1     Pending   0          6m23s
kube-prometheus-stack-58-prometheus-node-exporter-ddg8f        0/1     Pending   0          6m23s
kube-prometheus-stack-58-prometheus-node-exporter-ph9xn        0/1     Pending   0          6m23s
master@master:~$ kubectl --namespace default get pods -l "release=kube-prometheus-stack-58"
NAME                                                           READY   STATUS    RESTARTS   AGE
kube-prometheus-stack-58-kube-state-metrics-7567d9979b-lh59z   1/1     Running   0          6m23s
kube-prometheus-stack-58-operator-9b94b94dd-znr56              1/1     Running   0          6m24s
kube-prometheus-stack-58-prometheus-node-exporter-29w6q        0/1     Pending   0          6m24s
kube-prometheus-stack-58-prometheus-node-exporter-ddg8f        0/1     Pending   0          6m24s
kube-prometheus-stack-58-prometheus-node-exporter-ph9xn        0/1     Pending   0          6m24s
master@master:~$ screen -S prometheus
[screen is terminating]
master@master:~$ kubectl --namespace default get pods -l "release=kube-prometheus-stack-58"
NAME                                                           READY   STATUS    RESTARTS   AGE
kube-prometheus-stack-58-kube-state-metrics-7567d9979b-lh59z   1/1     Running   0          7m9s
kube-prometheus-stack-58-operator-9b94b94dd-znr56              1/1     Running   0          7m10s
kube-prometheus-stack-58-prometheus-node-exporter-29w6q        0/1     Pending   0          7m10s
kube-prometheus-stack-58-prometheus-node-exporter-ddg8f        0/1     Pending   0          7m10s
kube-prometheus-stack-58-prometheus-node-exporter-ph9xn        0/1     Pending   0          7m10s
master@master:~$ kubectl --namespace default get pods -l "release=kube-prometheus-stack-58"^C
master@master:~$ ^C
master@master:~$ ^C
master@master:~$ kubectl get pods -n default
NAME                                                              READY   STATUS    RESTARTS        AGE
alertmanager-kube-prometheus-stack-58-alertmanager-0              2/2     Running   0               6m55s
hello-pod                                                         1/1     Running   1 (2m11s ago)   62m
kube-prometheus-stack-58-grafana-678c99f77b-nmrjr                 3/3     Running   0               7m38s
kube-prometheus-stack-58-kube-state-metrics-7567d9979b-lh59z      1/1     Running   0               7m38s
kube-prometheus-stack-58-operator-9b94b94dd-znr56                 1/1     Running   0               7m39s
kube-prometheus-stack-58-prometheus-node-exporter-29w6q           0/1     Pending   0               7m39s
kube-prometheus-stack-58-prometheus-node-exporter-ddg8f           0/1     Pending   0               7m39s
kube-prometheus-stack-58-prometheus-node-exporter-ph9xn           0/1     Pending   0               7m39s
kube-prometheus-stack-58.7-operator-5dd75b7cc4-hkzrg              1/1     Running   0               9m3s
kube-prometheus-stack-58.7.2-grafana-67fffc6d89-jknqx             3/3     Running   0               9m3s
kube-prometheus-stack-58.7.2-kube-state-metrics-94bb4dcb8-gmvqz   1/1     Running   0               9m3s
kube-prometheus-stack-58.7.2-prometheus-node-exporter-lfp2r       1/1     Running   0               9m3s
kube-prometheus-stack-58.7.2-prometheus-node-exporter-wsnf5       1/1     Running   0               9m3s
kube-prometheus-stack-58.7.2-prometheus-node-exporter-x68vv       1/1     Running   0               9m3s
prometheus-kube-prometheus-stack-58-prometheus-0                  2/2     Running   0               6m54s
master@master:~$ kubectl get pods -n default
NAME                                                              READY   STATUS    RESTARTS        AGE
alertmanager-kube-prometheus-stack-58-alertmanager-0              2/2     Running   0               8m5s
hello-pod                                                         1/1     Running   1 (3m21s ago)   63m
kube-prometheus-stack-58-grafana-678c99f77b-nmrjr                 3/3     Running   0               8m48s
kube-prometheus-stack-58-kube-state-metrics-7567d9979b-lh59z      1/1     Running   0               8m48s
kube-prometheus-stack-58-operator-9b94b94dd-znr56                 1/1     Running   0               8m49s
kube-prometheus-stack-58-prometheus-node-exporter-29w6q           0/1     Pending   0               8m49s
kube-prometheus-stack-58-prometheus-node-exporter-ddg8f           0/1     Pending   0               8m49s
kube-prometheus-stack-58-prometheus-node-exporter-ph9xn           0/1     Pending   0               8m49s
kube-prometheus-stack-58.7-operator-5dd75b7cc4-hkzrg              1/1     Running   0               10m
kube-prometheus-stack-58.7.2-grafana-67fffc6d89-jknqx             3/3     Running   0               10m
kube-prometheus-stack-58.7.2-kube-state-metrics-94bb4dcb8-gmvqz   1/1     Running   0               10m
kube-prometheus-stack-58.7.2-prometheus-node-exporter-lfp2r       1/1     Running   0               10m
kube-prometheus-stack-58.7.2-prometheus-node-exporter-wsnf5       1/1     Running   0               10m
kube-prometheus-stack-58.7.2-prometheus-node-exporter-x68vv       1/1     Running   0               10m
prometheus-kube-prometheus-stack-58-prometheus-0                  2/2     Running   0               8m4s
master@master:~$ screen -S grafana
[screen is terminating]
master@master:~$ screen -S grafana
[screen is terminating]
master@master:~$ kubectl get pods -n default^C
master@master:~$ ^C
master@master:~$ ^C
master@master:~$ kubectl get pods -n default
NAME                                                              READY   STATUS    RESTARTS        AGE
alertmanager-kube-prometheus-stack-58-alertmanager-0              2/2     Running   0               11m
hello-pod                                                         1/1     Running   1 (7m14s ago)   67m
kube-prometheus-stack-58-grafana-678c99f77b-nmrjr                 3/3     Running   0               12m
kube-prometheus-stack-58-kube-state-metrics-7567d9979b-lh59z      1/1     Running   0               12m
kube-prometheus-stack-58-operator-9b94b94dd-znr56                 1/1     Running   0               12m
kube-prometheus-stack-58-prometheus-node-exporter-29w6q           0/1     Pending   0               12m
kube-prometheus-stack-58-prometheus-node-exporter-ddg8f           0/1     Pending   0               12m
kube-prometheus-stack-58-prometheus-node-exporter-ph9xn           0/1     Pending   0               12m
kube-prometheus-stack-58.7-operator-5dd75b7cc4-hkzrg              1/1     Running   0               14m
kube-prometheus-stack-58.7.2-grafana-67fffc6d89-jknqx             3/3     Running   0               14m
kube-prometheus-stack-58.7.2-kube-state-metrics-94bb4dcb8-gmvqz   1/1     Running   0               14m
kube-prometheus-stack-58.7.2-prometheus-node-exporter-lfp2r       1/1     Running   0               14m
kube-prometheus-stack-58.7.2-prometheus-node-exporter-wsnf5       1/1     Running   0               14m
kube-prometheus-stack-58.7.2-prometheus-node-exporter-x68vv       1/1     Running   0               14m
prometheus-kube-prometheus-stack-58-prometheus-0                  2/2     Running   0               11m
master@master:~$ kubectl describe pod kube-prometheus-stack-58-prometheus-node-exporter-29w6q -n default
Name:             kube-prometheus-stack-58-prometheus-node-exporter-29w6q
Namespace:        default
Priority:         0
Service Account:  kube-prometheus-stack-58-prometheus-node-exporter
Node:             <none>
Labels:           app.kubernetes.io/component=metrics
                  app.kubernetes.io/instance=kube-prometheus-stack-58
                  app.kubernetes.io/managed-by=Helm
                  app.kubernetes.io/name=prometheus-node-exporter
                  app.kubernetes.io/part-of=prometheus-node-exporter
                  app.kubernetes.io/version=1.8.0
                  controller-revision-hash=646744f667
                  helm.sh/chart=prometheus-node-exporter-4.34.0
                  jobLabel=node-exporter
                  pod-template-generation=1
                  release=kube-prometheus-stack-58
Annotations:      cluster-autoscaler.kubernetes.io/safe-to-evict: true
Status:           Pending
IP:               
IPs:              <none>
Controlled By:    DaemonSet/kube-prometheus-stack-58-prometheus-node-exporter
Containers:
  node-exporter:
    Image:      quay.io/prometheus/node-exporter:v1.8.0
    Port:       9100/TCP
    Host Port:  9100/TCP
    Args:
      --path.procfs=/host/proc
      --path.sysfs=/host/sys
      --path.rootfs=/host/root
      --path.udev.data=/host/root/run/udev/data
      --web.listen-address=[$(HOST_IP)]:9100
      --collector.filesystem.mount-points-exclude=^/(dev|proc|sys|var/lib/docker/.+|var/lib/kubelet/.+)($|/)
      --collector.filesystem.fs-types-exclude=^(autofs|binfmt_misc|bpf|cgroup2?|configfs|debugfs|devpts|devtmpfs|fusectl|hugetlbfs|iso9660|mqueue|nsfs|overlay|proc|procfs|pstore|rpc_pipefs|securityfs|selinuxfs|squashfs|sysfs|tracefs)$
    Liveness:   http-get http://:9100/ delay=0s timeout=1s period=10s #success=1 #failure=3
    Readiness:  http-get http://:9100/ delay=0s timeout=1s period=10s #success=1 #failure=3
    Environment:
      HOST_IP:  0.0.0.0
    Mounts:
      /host/proc from proc (ro)
      /host/root from root (ro)
      /host/sys from sys (ro)
Conditions:
  Type           Status
  PodScheduled   False 
Volumes:
  proc:
    Type:          HostPath (bare host directory volume)
    Path:          /proc
    HostPathType:  
  sys:
    Type:          HostPath (bare host directory volume)
    Path:          /sys
    HostPathType:  
  root:
    Type:          HostPath (bare host directory volume)
    Path:          /
    HostPathType:  
QoS Class:         BestEffort
Node-Selectors:    kubernetes.io/os=linux
Tolerations:       :NoSchedule op=Exists
                   node.kubernetes.io/disk-pressure:NoSchedule op=Exists
                   node.kubernetes.io/memory-pressure:NoSchedule op=Exists
                   node.kubernetes.io/network-unavailable:NoSchedule op=Exists
                   node.kubernetes.io/not-ready:NoExecute op=Exists
                   node.kubernetes.io/pid-pressure:NoSchedule op=Exists
                   node.kubernetes.io/unreachable:NoExecute op=Exists
                   node.kubernetes.io/unschedulable:NoSchedule op=Exists
Events:
  Type     Reason            Age                 From               Message
  ----     ------            ----                ----               -------
  Warning  FailedScheduling  115s                default-scheduler  0/3 nodes are available: 1 node(s) didn't have free ports for the requested pod ports, 2 node is filtered out by the prefilter result. preemption: 0/3 nodes are available: 1 No preemption victims found for incoming pod, 2 Preemption is not helpful for scheduling.
  Warning  FailedScheduling  7m8s (x6 over 13m)  default-scheduler  0/3 nodes are available: 1 node(s) didn't have free ports for the requested pod ports, 2 node is filtered out by the prefilter result. preemption: 0/3 nodes are available: 1 No preemption victims found for incoming pod, 2 Preemption is not helpful for scheduling.
master@master:~$ helm list -n default
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
NAME                        	NAMESPACE	REVISION	UPDATED                                	STATUS  	CHART                       	APP VERSION
kube-prometheus-stack       	default  	1       	2024-05-26 17:59:42.218584055 +0000 UTC	failed  	kube-prometheus-stack-58.7.2	v0.73.2    
kube-prometheus-stack-58    	default  	1       	2024-05-26 18:27:14.921630444 +0000 UTC	deployed	kube-prometheus-stack-58.7.2	v0.73.2    
kube-prometheus-stack-58.7.2	default  	1       	2024-05-26 18:25:55.394553368 +0000 UTC	failed  	kube-prometheus-stack-58.7.2	v0.73.2    
master@master:~$ helm uninstall kube-prometheus-stack -n default
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
release "kube-prometheus-stack" uninstalled
master@master:~$ helm list -n default
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
NAME                        	NAMESPACE	REVISION	UPDATED                                	STATUS  	CHART                       	APP VERSION
kube-prometheus-stack-58    	default  	1       	2024-05-26 18:27:14.921630444 +0000 UTC	deployed	kube-prometheus-stack-58.7.2	v0.73.2    
kube-prometheus-stack-58.7.2	default  	1       	2024-05-26 18:25:55.394553368 +0000 UTC	failed  	kube-prometheus-stack-58.7.2	v0.73.2    
master@master:~$ helm uninstall kube-prometheus-stack-58.7.2 -n default
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
release "kube-prometheus-stack-58.7.2" uninstalled
master@master:~$ helm list -n default
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
NAME                    	NAMESPACE	REVISION	UPDATED                                	STATUS  	CHART                       	APP VERSION
kube-prometheus-stack-58	default  	1       	2024-05-26 18:27:14.921630444 +0000 UTC	deployed	kube-prometheus-stack-58.7.2	v0.73.2    
master@master:~$ kubectl get pods -n default
NAME                                                           READY   STATUS    RESTARTS        AGE
alertmanager-kube-prometheus-stack-58-alertmanager-0           2/2     Running   0               14m
hello-pod                                                      1/1     Running   1 (9m52s ago)   70m
kube-prometheus-stack-58-grafana-678c99f77b-nmrjr              3/3     Running   0               15m
kube-prometheus-stack-58-kube-state-metrics-7567d9979b-lh59z   1/1     Running   0               15m
kube-prometheus-stack-58-operator-9b94b94dd-znr56              1/1     Running   0               15m
kube-prometheus-stack-58-prometheus-node-exporter-29w6q        1/1     Running   0               15m
kube-prometheus-stack-58-prometheus-node-exporter-ddg8f        1/1     Running   0               15m
kube-prometheus-stack-58-prometheus-node-exporter-ph9xn        1/1     Running   0               15m
prometheus-kube-prometheus-stack-58-prometheus-0               2/2     Running   0               14m
master@master:~$ kubectl port-forward -n default svc/kube-prometheus-stack-58-grafana 3000:80
Forwarding from 127.0.0.1:3000 -> 3000
Forwarding from [::1]:3000 -> 3000
^Cmaster@master:~$ ^C
master@master:~$ ^C
master@master:~$ screen -S grafana
[detached from 124032.grafana]
master@master:~$ screen -S prometheus
[detached from 124167.prometheus]
master@master:~$ screen -ls
There are screens on:
	124167.prometheus	(05/26/24 18:44:25)	(Detached)
	124032.grafana	(05/26/24 18:43:37)	(Detached)
	112619.kubernetes-dashboard	(05/26/24 17:35:00)	(Detached)
3 Sockets in /run/screen/S-master.
master@master:~$ screen -dr kubernetes-dashboard
[detached from 112619.kubernetes-dashboard]
master@master:~$ screen -dr grafana
[detached from 124032.grafana]
master@master:~$ screen -dr prometheus
[detached from 124167.prometheus]
master@master:~$ screen -dr grafana
[detached from 124032.grafana]
master@master:~$ screen -dr prometheus
[detached from 124167.prometheus]
master@master:~$ screen -dr prometheus
[detached from 124167.prometheus]
master@master:~$ screen -dr prometheus
[detached from 124167.prometheus]
master@master:~$ screen -dr prometheus
[detached from 124167.prometheus]
master@master:~$ screen -dr grafana
[detached from 124032.grafana]
master@master:~$ screen -dr prometheus
[detached from 124167.prometheus]
master@master:~$ screen -dr prometheus
[detached from 124167.prometheus]
master@master:~$ screen -S alert-manager
[detached from 126171.alert-manager]
master@master:~$ kubectl get pods -n default
NAME                                                           READY   STATUS    RESTARTS      AGE
alertmanager-kube-prometheus-stack-58-alertmanager-0           2/2     Running   0             29m
hello-pod                                                      1/1     Running   1 (24m ago)   85m
kube-prometheus-stack-58-grafana-678c99f77b-nmrjr              3/3     Running   0             30m
kube-prometheus-stack-58-kube-state-metrics-7567d9979b-lh59z   1/1     Running   0             30m
kube-prometheus-stack-58-operator-9b94b94dd-znr56              1/1     Running   0             30m
kube-prometheus-stack-58-prometheus-node-exporter-29w6q        1/1     Running   0             30m
kube-prometheus-stack-58-prometheus-node-exporter-ddg8f        1/1     Running   0             30m
kube-prometheus-stack-58-prometheus-node-exporter-ph9xn        1/1     Running   0             30m
prometheus-kube-prometheus-stack-58-prometheus-0               2/2     Running   0             29m
master@master:~$ screen -S alert-manager
[detached from 126480.alert-manager]
master@master:~$ screen -dr prometheus
[detached from 124167.prometheus]
master@master:~$ kubectl get all svc
error: you must specify only one resource
master@master:~$ kubectl get svc -n default
NAME                                                TYPE        CLUSTER-IP       EXTERNAL-IP   PORT(S)                      AGE
alertmanager-operated                               ClusterIP   None             <none>        9093/TCP,9094/TCP,9094/UDP   32m
kube-prometheus-stack-58-alertmanager               ClusterIP   10.102.117.194   <none>        9093/TCP,8080/TCP            33m
kube-prometheus-stack-58-grafana                    ClusterIP   10.108.165.38    <none>        80/TCP                       33m
kube-prometheus-stack-58-kube-state-metrics         ClusterIP   10.101.149.147   <none>        8080/TCP                     33m
kube-prometheus-stack-58-operator                   ClusterIP   10.97.204.32     <none>        443/TCP                      33m
kube-prometheus-stack-58-prometheus                 ClusterIP   10.110.175.138   <none>        9090/TCP,8080/TCP            33m
kube-prometheus-stack-58-prometheus-node-exporter   ClusterIP   10.99.203.2      <none>        9100/TCP                     33m
kubernetes                                          ClusterIP   10.96.0.1        <none>        443/TCP                      91m
prometheus-operated                                 ClusterIP   None             <none>        9090/TCP                     32m
master@master:~$ kubectl get svc -n default -o wide
NAME                                                TYPE        CLUSTER-IP       EXTERNAL-IP   PORT(S)                      AGE   SELECTOR
alertmanager-operated                               ClusterIP   None             <none>        9093/TCP,9094/TCP,9094/UDP   33m   app.kubernetes.io/name=alertmanager
kube-prometheus-stack-58-alertmanager               ClusterIP   10.102.117.194   <none>        9093/TCP,8080/TCP            33m   alertmanager=kube-prometheus-stack-58-alertmanager,app.kubernetes.io/name=alertmanager
kube-prometheus-stack-58-grafana                    ClusterIP   10.108.165.38    <none>        80/TCP                       33m   app.kubernetes.io/instance=kube-prometheus-stack-58,app.kubernetes.io/name=grafana
kube-prometheus-stack-58-kube-state-metrics         ClusterIP   10.101.149.147   <none>        8080/TCP                     33m   app.kubernetes.io/instance=kube-prometheus-stack-58,app.kubernetes.io/name=kube-state-metrics
kube-prometheus-stack-58-operator                   ClusterIP   10.97.204.32     <none>        443/TCP                      33m   app=kube-prometheus-stack-operator,release=kube-prometheus-stack-58
kube-prometheus-stack-58-prometheus                 ClusterIP   10.110.175.138   <none>        9090/TCP,8080/TCP            33m   app.kubernetes.io/name=prometheus,operator.prometheus.io/name=kube-prometheus-stack-58-prometheus
kube-prometheus-stack-58-prometheus-node-exporter   ClusterIP   10.99.203.2      <none>        9100/TCP                     33m   app.kubernetes.io/instance=kube-prometheus-stack-58,app.kubernetes.io/name=prometheus-node-exporter
kubernetes                                          ClusterIP   10.96.0.1        <none>        443/TCP                      91m   <none>
prometheus-operated                                 ClusterIP   None             <none>        9090/TCP                     33m   app.kubernetes.io/name=prometheus
master@master:~$ screen -S alert-manager
[detached from 127045.alert-manager]
master@master:~$ screen -dr grafana
[detached from 124032.grafana]
master@master:~$ screen -dr prometheus
[detached from 124167.prometheus]
master@master:~$ 
```
