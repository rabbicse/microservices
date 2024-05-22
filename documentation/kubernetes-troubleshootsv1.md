mehmet@mehmet-H170-Gaming-3:~$ ssh master@192.168.0.193
master@192.168.0.193's password: 
Welcome to Ubuntu 24.04 LTS (GNU/Linux 6.8.0-31-generic x86_64)

 * Documentation:  https://help.ubuntu.com
 * Management:     https://landscape.canonical.com
 * Support:        https://ubuntu.com/pro

This system has been minimized by removing packages and content that are
not required on a system that users do not log into.

To restore this content, you can run the 'unminimize' command.
Last login: Tue May 21 14:28:33 2024 from 192.168.0.197
master@master:~$ sudo swapoff -a 
[sudo] password for master: 
master@master:~$ free -h
               total        used        free      shared  buff/cache   available
Mem:           7.7Gi       605Mi       6.2Gi       1.8Mi       1.2Gi       7.1Gi
Swap:             0B          0B          0B
master@master:~$ sudo modprobe overlay
master@master:~$ sudo modprobe br_netfilter
master@master:~$ sudo tee /etc/sysctl.d/kubernetes.conf<<EOF
> net.bridge.bridge-nf-call-ip6tables = 1
> net.bridge.bridge-nf-call-iptables = 1
> net.ipv4.ip_forward = 1
> EOF
net.bridge.bridge-nf-call-ip6tables = 1
net.bridge.bridge-nf-call-iptables = 1
net.ipv4.ip_forward = 1
master@master:~$ sudo sysctl --system
* Applying /usr/lib/sysctl.d/10-apparmor.conf ...
* Applying /etc/sysctl.d/10-console-messages.conf ...
* Applying /etc/sysctl.d/10-ipv6-privacy.conf ...
* Applying /etc/sysctl.d/10-kernel-hardening.conf ...
* Applying /etc/sysctl.d/10-magic-sysrq.conf ...
* Applying /etc/sysctl.d/10-map-count.conf ...
* Applying /etc/sysctl.d/10-network-security.conf ...
* Applying /etc/sysctl.d/10-ptrace.conf ...
* Applying /etc/sysctl.d/10-zeropage.conf ...
* Applying /usr/lib/sysctl.d/50-pid-max.conf ...
* Applying /usr/lib/sysctl.d/99-protect-links.conf ...
* Applying /etc/sysctl.d/99-sysctl.conf ...
* Applying /etc/sysctl.d/kubernetes.conf ...
* Applying /etc/sysctl.conf ...
kernel.apparmor_restrict_unprivileged_userns = 1
kernel.printk = 4 4 1 7
net.ipv6.conf.all.use_tempaddr = 2
net.ipv6.conf.default.use_tempaddr = 2
kernel.kptr_restrict = 1
kernel.sysrq = 176
vm.max_map_count = 1048576
net.ipv4.conf.default.rp_filter = 2
net.ipv4.conf.all.rp_filter = 2
kernel.yama.ptrace_scope = 1
vm.mmap_min_addr = 65536
kernel.pid_max = 4194304
fs.protected_fifos = 1
fs.protected_hardlinks = 1
fs.protected_regular = 2
fs.protected_symlinks = 1
net.ipv4.ip_forward = 1
net.bridge.bridge-nf-call-ip6tables = 1
net.bridge.bridge-nf-call-iptables = 1
net.ipv4.ip_forward = 1
net.ipv4.ip_forward = 1
master@master:~$ sudo tee /etc/modules-load.d/k8s.conf <<EOF
overlay
br_netfilter
EOF
overlay
br_netfilter
master@master:~$ sudo modprobe overlay
sudo modprobe br_netfilter
master@master:~$ sudo tee /etc/sysctl.d/kubernetes.conf<<EOF
net.bridge.bridge-nf-call-ip6tables = 1
net.bridge.bridge-nf-call-iptables = 1
net.ipv4.ip_forward = 1
EOF
net.bridge.bridge-nf-call-ip6tables = 1
net.bridge.bridge-nf-call-iptables = 1
net.ipv4.ip_forward = 1
master@master:~$ sudo sysctl --system
* Applying /usr/lib/sysctl.d/10-apparmor.conf ...
* Applying /etc/sysctl.d/10-console-messages.conf ...
* Applying /etc/sysctl.d/10-ipv6-privacy.conf ...
* Applying /etc/sysctl.d/10-kernel-hardening.conf ...
* Applying /etc/sysctl.d/10-magic-sysrq.conf ...
* Applying /etc/sysctl.d/10-map-count.conf ...
* Applying /etc/sysctl.d/10-network-security.conf ...
* Applying /etc/sysctl.d/10-ptrace.conf ...
* Applying /etc/sysctl.d/10-zeropage.conf ...
* Applying /usr/lib/sysctl.d/50-pid-max.conf ...
* Applying /usr/lib/sysctl.d/99-protect-links.conf ...
* Applying /etc/sysctl.d/99-sysctl.conf ...
* Applying /etc/sysctl.d/kubernetes.conf ...
* Applying /etc/sysctl.conf ...
kernel.apparmor_restrict_unprivileged_userns = 1
kernel.printk = 4 4 1 7
net.ipv6.conf.all.use_tempaddr = 2
net.ipv6.conf.default.use_tempaddr = 2
kernel.kptr_restrict = 1
kernel.sysrq = 176
vm.max_map_count = 1048576
net.ipv4.conf.default.rp_filter = 2
net.ipv4.conf.all.rp_filter = 2
kernel.yama.ptrace_scope = 1
vm.mmap_min_addr = 65536
kernel.pid_max = 4194304
fs.protected_fifos = 1
fs.protected_hardlinks = 1
fs.protected_regular = 2
fs.protected_symlinks = 1
net.ipv4.ip_forward = 1
net.bridge.bridge-nf-call-ip6tables = 1
net.bridge.bridge-nf-call-iptables = 1
net.ipv4.ip_forward = 1
net.ipv4.ip_forward = 1
master@master:~$ sudo mkdir -p /etc/containerd
master@master:~$ sudo containerd config default|sudo tee /etc/containerd/config.toml
disabled_plugins = []
imports = []
oom_score = 0
plugin_dir = ""
required_plugins = []
root = "/var/lib/containerd"
state = "/run/containerd"
temp = ""
version = 2

[cgroup]
  path = ""

[debug]
  address = ""
  format = ""
  gid = 0
  level = ""
  uid = 0

[grpc]
  address = "/run/containerd/containerd.sock"
  gid = 0
  max_recv_message_size = 16777216
  max_send_message_size = 16777216
  tcp_address = ""
  tcp_tls_ca = ""
  tcp_tls_cert = ""
  tcp_tls_key = ""
  uid = 0

[metrics]
  address = ""
  grpc_histogram = false

[plugins]

  [plugins."io.containerd.gc.v1.scheduler"]
    deletion_threshold = 0
    mutation_threshold = 100
    pause_threshold = 0.02
    schedule_delay = "0s"
    startup_delay = "100ms"

  [plugins."io.containerd.grpc.v1.cri"]
    device_ownership_from_security_context = false
    disable_apparmor = false
    disable_cgroup = false
    disable_hugetlb_controller = true
    disable_proc_mount = false
    disable_tcp_service = true
    drain_exec_sync_io_timeout = "0s"
    enable_selinux = false
    enable_tls_streaming = false
    enable_unprivileged_icmp = false
    enable_unprivileged_ports = false
    ignore_deprecation_warnings = []
    ignore_image_defined_volumes = false
    max_concurrent_downloads = 3
    max_container_log_line_size = 16384
    netns_mounts_under_state_dir = false
    restrict_oom_score_adj = false
    sandbox_image = "registry.k8s.io/pause:3.6"
    selinux_category_range = 1024
    stats_collect_period = 10
    stream_idle_timeout = "4h0m0s"
    stream_server_address = "127.0.0.1"
    stream_server_port = "0"
    systemd_cgroup = false
    tolerate_missing_hugetlb_controller = true
    unset_seccomp_profile = ""

    [plugins."io.containerd.grpc.v1.cri".cni]
      bin_dir = "/opt/cni/bin"
      conf_dir = "/etc/cni/net.d"
      conf_template = ""
      ip_pref = ""
      max_conf_num = 1

    [plugins."io.containerd.grpc.v1.cri".containerd]
      default_runtime_name = "runc"
      disable_snapshot_annotations = true
      discard_unpacked_layers = false
      ignore_rdt_not_enabled_errors = false
      no_pivot = false
      snapshotter = "overlayfs"

      [plugins."io.containerd.grpc.v1.cri".containerd.default_runtime]
        base_runtime_spec = ""
        cni_conf_dir = ""
        cni_max_conf_num = 0
        container_annotations = []
        pod_annotations = []
        privileged_without_host_devices = false
        runtime_engine = ""
        runtime_path = ""
        runtime_root = ""
        runtime_type = ""

        [plugins."io.containerd.grpc.v1.cri".containerd.default_runtime.options]

      [plugins."io.containerd.grpc.v1.cri".containerd.runtimes]

        [plugins."io.containerd.grpc.v1.cri".containerd.runtimes.runc]
          base_runtime_spec = ""
          cni_conf_dir = ""
          cni_max_conf_num = 0
          container_annotations = []
          pod_annotations = []
          privileged_without_host_devices = false
          runtime_engine = ""
          runtime_path = ""
          runtime_root = ""
          runtime_type = "io.containerd.runc.v2"

          [plugins."io.containerd.grpc.v1.cri".containerd.runtimes.runc.options]
            BinaryName = ""
            CriuImagePath = ""
            CriuPath = ""
            CriuWorkPath = ""
            IoGid = 0
            IoUid = 0
            NoNewKeyring = false
            NoPivotRoot = false
            Root = ""
            ShimCgroup = ""
            SystemdCgroup = false

      [plugins."io.containerd.grpc.v1.cri".containerd.untrusted_workload_runtime]
        base_runtime_spec = ""
        cni_conf_dir = ""
        cni_max_conf_num = 0
        container_annotations = []
        pod_annotations = []
        privileged_without_host_devices = false
        runtime_engine = ""
        runtime_path = ""
        runtime_root = ""
        runtime_type = ""

        [plugins."io.containerd.grpc.v1.cri".containerd.untrusted_workload_runtime.options]

    [plugins."io.containerd.grpc.v1.cri".image_decryption]
      key_model = "node"

    [plugins."io.containerd.grpc.v1.cri".registry]
      config_path = ""

      [plugins."io.containerd.grpc.v1.cri".registry.auths]

      [plugins."io.containerd.grpc.v1.cri".registry.configs]

      [plugins."io.containerd.grpc.v1.cri".registry.headers]

      [plugins."io.containerd.grpc.v1.cri".registry.mirrors]

    [plugins."io.containerd.grpc.v1.cri".x509_key_pair_streaming]
      tls_cert_file = ""
      tls_key_file = ""

  [plugins."io.containerd.internal.v1.opt"]
    path = "/opt/containerd"

  [plugins."io.containerd.internal.v1.restart"]
    interval = "10s"

  [plugins."io.containerd.internal.v1.tracing"]
    sampling_ratio = 1.0
    service_name = "containerd"

  [plugins."io.containerd.metadata.v1.bolt"]
    content_sharing_policy = "shared"

  [plugins."io.containerd.monitor.v1.cgroups"]
    no_prometheus = false

  [plugins."io.containerd.runtime.v1.linux"]
    no_shim = false
    runtime = "runc"
    runtime_root = ""
    shim = "containerd-shim"
    shim_debug = false

  [plugins."io.containerd.runtime.v2.task"]
    platforms = ["linux/amd64"]
    sched_core = false

  [plugins."io.containerd.service.v1.diff-service"]
    default = ["walking"]

  [plugins."io.containerd.service.v1.tasks-service"]
    rdt_config_file = ""

  [plugins."io.containerd.snapshotter.v1.aufs"]
    root_path = ""

  [plugins."io.containerd.snapshotter.v1.btrfs"]
    root_path = ""

  [plugins."io.containerd.snapshotter.v1.devmapper"]
    async_remove = false
    base_image_size = ""
    discard_blocks = false
    fs_options = ""
    fs_type = ""
    pool_name = ""
    root_path = ""

  [plugins."io.containerd.snapshotter.v1.native"]
    root_path = ""

  [plugins."io.containerd.snapshotter.v1.overlayfs"]
    mount_options = []
    root_path = ""
    sync_remove = false
    upperdir_label = false

  [plugins."io.containerd.snapshotter.v1.zfs"]
    root_path = ""

  [plugins."io.containerd.tracing.processor.v1.otlp"]
    endpoint = ""
    insecure = false
    protocol = ""

[proxy_plugins]

[stream_processors]

  [stream_processors."io.containerd.ocicrypt.decoder.v1.tar"]
    accepts = ["application/vnd.oci.image.layer.v1.tar+encrypted"]
    args = ["--decryption-keys-path", "/etc/containerd/ocicrypt/keys"]
    env = ["OCICRYPT_KEYPROVIDER_CONFIG=/etc/containerd/ocicrypt/ocicrypt_keyprovider.conf"]
    path = "ctd-decoder"
    returns = "application/vnd.oci.image.layer.v1.tar"

  [stream_processors."io.containerd.ocicrypt.decoder.v1.tar.gzip"]
    accepts = ["application/vnd.oci.image.layer.v1.tar+gzip+encrypted"]
    args = ["--decryption-keys-path", "/etc/containerd/ocicrypt/keys"]
    env = ["OCICRYPT_KEYPROVIDER_CONFIG=/etc/containerd/ocicrypt/ocicrypt_keyprovider.conf"]
    path = "ctd-decoder"
    returns = "application/vnd.oci.image.layer.v1.tar+gzip"

[timeouts]
  "io.containerd.timeout.bolt.open" = "0s"
  "io.containerd.timeout.shim.cleanup" = "5s"
  "io.containerd.timeout.shim.load" = "5s"
  "io.containerd.timeout.shim.shutdown" = "3s"
  "io.containerd.timeout.task.state" = "2s"

[ttrpc]
  address = ""
  gid = 0
  uid = 0
master@master:~$ sudo vi /etc/containerd/config.toml
master@master:~$ sudo systemctl restart containerd
sudo systemctl enable containerd
systemctl status containerd
● containerd.service - containerd container runtime
     Loaded: loaded (/usr/lib/systemd/system/containerd.service; enabled; preset: enabled)
     Active: active (running) since Tue 2024-05-21 17:43:35 UTC; 360ms ago
       Docs: https://containerd.io
   Main PID: 33113 (containerd)
      Tasks: 100
     Memory: 149.8M (peak: 177.5M)
        CPU: 216ms
     CGroup: /system.slice/containerd.service
             ├─ 4017 /usr/bin/containerd-shim-runc-v2 -namespace k8s.io -id 107e781c42d83d273f9877cb01cd4eb916626a265cb5f05b3323539c84f0a646 -address /run/containerd/contain
erd.sock
             ├─10572 /usr/bin/containerd-shim-runc-v2 -namespace k8s.io -id 777183cde6ff90a77b332771fbb606ea3704fdf354b589abbeb3d7c3c292b5de -address /run/containerd/contain
erd.sock
             ├─31063 /usr/bin/containerd-shim-runc-v2 -namespace k8s.io -id 0e3caf2930f79c9a1589d3f429a1234c9b7172fc7d3408f80767d41136759e78 -address /run/containerd/contain
erd.sock
             ├─31754 /usr/bin/containerd-shim-runc-v2 -namespace k8s.io -id 891ae1b6a2cf2dc5ff596c695350f00d82ead29c39dbdd57b3b5fb83e5adde87 -address /run/containerd/contain
erd.sock
             ├─32031 /usr/bin/containerd-shim-runc-v2 -namespace k8s.io -id 91966c42d38246e56f40228efd22e4f9c6674574a00bf6ae5fb69c97e752771e -address /run/containerd/contain
erd.sock
             ├─32318 /usr/bin/containerd-shim-runc-v2 -namespace k8s.io -id 5a224382c2824caa8614fc0b061d145ef0c2dec952c077462fd7545c50f70b2d -address /run/containerd/contain
erd.sock
             ├─32684 /usr/bin/containerd-shim-runc-v2 -namespace k8s.io -id e3c21e3193ecdc70856894831f65580bedb850addda65f5e170d4b4f02ae122b -address /run/containerd/contain
erd.sock
             ├─32874 /usr/bin/containerd-shim-runc-v2 -namespace k8s.io -id 9f994ff166eb05569622a7e815a4d6147e9ab10c025e9cf05e7f45c54ca469ec -address /run/containerd/contain
erd.sock
             └─33113 /usr/bin/containerd

May 21 17:43:35 master containerd[33113]: time="2024-05-21T17:43:35.578171637Z" level=info msg="Start subscribing containerd event"
May 21 17:43:35 master containerd[33113]: time="2024-05-21T17:43:35.578295807Z" level=info msg="Start recovering state"
May 21 17:43:35 master containerd[33113]: time="2024-05-21T17:43:35.578839519Z" level=info msg=serving... address=/run/containerd/containerd.sock.ttrpc
May 21 17:43:35 master containerd[33113]: time="2024-05-21T17:43:35.579037182Z" level=info msg=serving... address=/run/containerd/containerd.sock
May 21 17:43:35 master containerd[33113]: time="2024-05-21T17:43:35.669468674Z" level=info msg="Start event monitor"
May 21 17:43:35 master containerd[33113]: time="2024-05-21T17:43:35.669518177Z" level=info msg="Start snapshots syncer"
May 21 17:43:35 master containerd[33113]: time="2024-05-21T17:43:35.669533257Z" level=info msg="Start cni network conf syncer for default"
May 21 17:43:35 master containerd[33113]: time="2024-05-21T17:43:35.669540571Z" level=info msg="Start streaming server"
May 21 17:43:35 master containerd[33113]: time="2024-05-21T17:43:35.669658475Z" level=info msg="containerd successfully booted in 0.130415s"
May 21 17:43:35 master systemd[1]: Started containerd.service - containerd container runtime.
master@master:~$ lsmod | grep br_netfilter
br_netfilter           32768  0
bridge                421888  1 br_netfilter
master@master:~$ sudo systemctl enable kubelet
master@master:~$ sudo kubeadm init --pod-network-cidr=192.168.0.0/16 --cri-socket=/var/run/containerd/containerd.sock
W0521 17:45:06.805695   33611 initconfiguration.go:125] Usage of CRI endpoints without URL scheme is deprecated and can cause kubelet errors in the future. Automatically prepending scheme "unix" to the "criSocket" with value "/var/run/containerd/containerd.sock". Please update your configuration!
[init] Using Kubernetes version: v1.30.1
[preflight] Running pre-flight checks
error execution phase preflight: [preflight] Some fatal errors occurred:
	[ERROR Port-10259]: Port 10259 is in use
	[ERROR FileAvailable--etc-kubernetes-manifests-kube-apiserver.yaml]: /etc/kubernetes/manifests/kube-apiserver.yaml already exists
	[ERROR FileAvailable--etc-kubernetes-manifests-kube-controller-manager.yaml]: /etc/kubernetes/manifests/kube-controller-manager.yaml already exists
	[ERROR FileAvailable--etc-kubernetes-manifests-kube-scheduler.yaml]: /etc/kubernetes/manifests/kube-scheduler.yaml already exists
	[ERROR FileAvailable--etc-kubernetes-manifests-etcd.yaml]: /etc/kubernetes/manifests/etcd.yaml already exists
	[ERROR Port-10250]: Port 10250 is in use
	[ERROR DirAvailable--var-lib-etcd]: /var/lib/etcd is not empty
[preflight] If you know what you are doing, you can make a check non-fatal with `--ignore-preflight-errors=...`
To see the stack trace of this error execute with --v=5 or higher
master@master:~$ sudo kubeadm init --pod-network-cidr=192.168.0.0/16 --cri-socket=/var/run/containerd/containerd.sock --v=5
W0521 17:46:01.704051   34019 initconfiguration.go:125] Usage of CRI endpoints without URL scheme is deprecated and can cause kubelet errors in the future. Automatically prepending scheme "unix" to the "criSocket" with value "/var/run/containerd/containerd.sock". Please update your configuration!
I0521 17:46:01.704314   34019 interface.go:432] Looking for default routes with IPv4 addresses
I0521 17:46:01.704340   34019 interface.go:437] Default route transits interface "ens33"
I0521 17:46:01.704466   34019 interface.go:209] Interface ens33 is up
I0521 17:46:01.704533   34019 interface.go:257] Interface "ens33" has 2 addresses :[192.168.0.193/24 fe80::20c:29ff:fe09:602d/64].
I0521 17:46:01.704542   34019 interface.go:224] Checking addr  192.168.0.193/24.
I0521 17:46:01.704564   34019 interface.go:231] IP found 192.168.0.193
I0521 17:46:01.704616   34019 interface.go:263] Found valid IPv4 address 192.168.0.193 for interface "ens33".
I0521 17:46:01.704630   34019 interface.go:443] Found active IP 192.168.0.193 
I0521 17:46:01.704646   34019 kubelet.go:196] the value of KubeletConfiguration.cgroupDriver is empty; setting it to "systemd"
I0521 17:46:01.711173   34019 version.go:187] fetching Kubernetes version from URL: https://dl.k8s.io/release/stable-1.txt
I0521 17:46:02.958447   34019 certs.go:483] validating certificate period for CA certificate
I0521 17:46:02.958735   34019 certs.go:483] validating certificate period for front-proxy CA certificate
[init] Using Kubernetes version: v1.30.1
[preflight] Running pre-flight checks
I0521 17:46:02.961476   34019 checks.go:561] validating Kubernetes and kubeadm version
I0521 17:46:02.961591   34019 checks.go:166] validating if the firewall is enabled and active
I0521 17:46:03.009124   34019 checks.go:201] validating availability of port 6443
I0521 17:46:03.009509   34019 checks.go:201] validating availability of port 10259
I0521 17:46:03.009609   34019 checks.go:201] validating availability of port 10257
I0521 17:46:03.009662   34019 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-apiserver.yaml
I0521 17:46:03.009690   34019 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-controller-manager.yaml
I0521 17:46:03.009709   34019 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-scheduler.yaml
I0521 17:46:03.009726   34019 checks.go:278] validating the existence of file /etc/kubernetes/manifests/etcd.yaml
I0521 17:46:03.009744   34019 checks.go:428] validating if the connectivity type is via proxy or direct
I0521 17:46:03.009766   34019 checks.go:467] validating http connectivity to first IP address in the CIDR
I0521 17:46:03.009784   34019 checks.go:467] validating http connectivity to first IP address in the CIDR
I0521 17:46:03.009841   34019 checks.go:102] validating the container runtime
I0521 17:46:03.041776   34019 checks.go:637] validating whether swap is enabled or not
I0521 17:46:03.041880   34019 checks.go:368] validating the presence of executable crictl
I0521 17:46:03.041940   34019 checks.go:368] validating the presence of executable conntrack
I0521 17:46:03.042021   34019 checks.go:368] validating the presence of executable ip
I0521 17:46:03.042126   34019 checks.go:368] validating the presence of executable iptables
I0521 17:46:03.042170   34019 checks.go:368] validating the presence of executable mount
I0521 17:46:03.042262   34019 checks.go:368] validating the presence of executable nsenter
I0521 17:46:03.042354   34019 checks.go:368] validating the presence of executable ebtables
I0521 17:46:03.042411   34019 checks.go:368] validating the presence of executable ethtool
I0521 17:46:03.042446   34019 checks.go:368] validating the presence of executable socat
I0521 17:46:03.042495   34019 checks.go:368] validating the presence of executable tc
I0521 17:46:03.042566   34019 checks.go:368] validating the presence of executable touch
I0521 17:46:03.042628   34019 checks.go:514] running all checks
I0521 17:46:03.058485   34019 checks.go:399] checking whether the given node name is valid and reachable using net.LookupHost
I0521 17:46:03.058554   34019 checks.go:603] validating kubelet version
I0521 17:46:03.112873   34019 checks.go:128] validating if the "kubelet" service is enabled and active
I0521 17:46:03.128944   34019 checks.go:201] validating availability of port 10250
I0521 17:46:03.129065   34019 checks.go:327] validating the contents of file /proc/sys/net/ipv4/ip_forward
I0521 17:46:03.129177   34019 checks.go:201] validating availability of port 2379
I0521 17:46:03.129282   34019 checks.go:201] validating availability of port 2380
I0521 17:46:03.129339   34019 checks.go:241] validating the existence and emptiness of directory /var/lib/etcd
[preflight] Some fatal errors occurred:
	[ERROR Port-10257]: Port 10257 is in use
	[ERROR FileAvailable--etc-kubernetes-manifests-kube-apiserver.yaml]: /etc/kubernetes/manifests/kube-apiserver.yaml already exists
	[ERROR FileAvailable--etc-kubernetes-manifests-kube-controller-manager.yaml]: /etc/kubernetes/manifests/kube-controller-manager.yaml already exists
	[ERROR FileAvailable--etc-kubernetes-manifests-kube-scheduler.yaml]: /etc/kubernetes/manifests/kube-scheduler.yaml already exists
	[ERROR FileAvailable--etc-kubernetes-manifests-etcd.yaml]: /etc/kubernetes/manifests/etcd.yaml already exists
	[ERROR Port-10250]: Port 10250 is in use
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
master@master:~$ sudo kubeadm reset -f
[reset] Reading configuration from the cluster...
[reset] FYI: You can look at this config file with 'kubectl -n kube-system get cm kubeadm-config -o yaml'
W0521 17:47:27.356221   34258 reset.go:124] [reset] Unable to fetch the kubeadm-config ConfigMap from cluster: failed to get config map: Get "https://192.168.0.193:6443/api/v1/namespaces/kube-system/configmaps/kubeadm-config?timeout=10s": context deadline exceeded
[preflight] Running pre-flight checks
W0521 17:47:27.356515   34258 removeetcdmember.go:106] [reset] No kubeadm config, using etcd pod spec to get data directory
[reset] Deleted contents of the etcd data directory: /var/lib/etcd
[reset] Stopping the kubelet service
[reset] Unmounting mounted directories in "/var/lib/kubelet"
W0521 17:47:29.727160   34258 cleanupnode.go:106] [reset] Failed to remove containers: [failed to stop running pod bffc3dfaebc124531c69db7997d571d447e055863120ab88afdc6d38b1bd5801: output: E0521 17:47:29.122496   34941 remote_runtime.go:222] "StopPodSandbox from runtime service failed" err="rpc error: code = Unknown desc = failed to destroy network for sandbox \"bffc3dfaebc124531c69db7997d571d447e055863120ab88afdc6d38b1bd5801\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused" podSandboxID="bffc3dfaebc124531c69db7997d571d447e055863120ab88afdc6d38b1bd5801"
time="2024-05-21T17:47:29Z" level=fatal msg="stopping the pod sandbox \"bffc3dfaebc124531c69db7997d571d447e055863120ab88afdc6d38b1bd5801\": rpc error: code = Unknown desc = failed to destroy network for sandbox \"bffc3dfaebc124531c69db7997d571d447e055863120ab88afdc6d38b1bd5801\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused"
: exit status 1, failed to stop running pod 36e721649fce509d96038e297e525c3c1c1ee548cc5eb7a4cf74cfc9469914ca: output: E0521 17:47:29.413328   35083 remote_runtime.go:222] "StopPodSandbox from runtime service failed" err="rpc error: code = Unknown desc = failed to destroy network for sandbox \"36e721649fce509d96038e297e525c3c1c1ee548cc5eb7a4cf74cfc9469914ca\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused" podSandboxID="36e721649fce509d96038e297e525c3c1c1ee548cc5eb7a4cf74cfc9469914ca"
time="2024-05-21T17:47:29Z" level=fatal msg="stopping the pod sandbox \"36e721649fce509d96038e297e525c3c1c1ee548cc5eb7a4cf74cfc9469914ca\": rpc error: code = Unknown desc = failed to destroy network for sandbox \"36e721649fce509d96038e297e525c3c1c1ee548cc5eb7a4cf74cfc9469914ca\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused"
: exit status 1, failed to stop running pod a56a760f2058551d4e1086116056c5a508b8b9f241d83f359caddd0bdc6fc187: output: E0521 17:47:29.725437   35223 remote_runtime.go:222] "StopPodSandbox from runtime service failed" err="rpc error: code = Unknown desc = failed to destroy network for sandbox \"a56a760f2058551d4e1086116056c5a508b8b9f241d83f359caddd0bdc6fc187\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused" podSandboxID="a56a760f2058551d4e1086116056c5a508b8b9f241d83f359caddd0bdc6fc187"
time="2024-05-21T17:47:29Z" level=fatal msg="stopping the pod sandbox \"a56a760f2058551d4e1086116056c5a508b8b9f241d83f359caddd0bdc6fc187\": rpc error: code = Unknown desc = failed to destroy network for sandbox \"a56a760f2058551d4e1086116056c5a508b8b9f241d83f359caddd0bdc6fc187\": plugin type=\"calico\" failed (delete): error getting ClusterInformation: Get \"https://10.96.0.1:443/apis/crd.projectcalico.org/v1/clusterinformations/default\": dial tcp 10.96.0.1:443: connect: connection refused"
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
master@master:~$ sudo kubeadm init --pod-network-cidr=192.168.0.0/16 --cri-socket=/var/run/containerd/containerd.sock --v=5
W0521 17:47:42.263234   35253 initconfiguration.go:125] Usage of CRI endpoints without URL scheme is deprecated and can cause kubelet errors in the future. Automatically prepending scheme "unix" to the "criSocket" with value "/var/run/containerd/containerd.sock". Please update your configuration!
I0521 17:47:42.263451   35253 interface.go:432] Looking for default routes with IPv4 addresses
I0521 17:47:42.263463   35253 interface.go:437] Default route transits interface "ens33"
I0521 17:47:42.263581   35253 interface.go:209] Interface ens33 is up
I0521 17:47:42.263621   35253 interface.go:257] Interface "ens33" has 2 addresses :[192.168.0.193/24 fe80::20c:29ff:fe09:602d/64].
I0521 17:47:42.263632   35253 interface.go:224] Checking addr  192.168.0.193/24.
I0521 17:47:42.263638   35253 interface.go:231] IP found 192.168.0.193
I0521 17:47:42.263645   35253 interface.go:263] Found valid IPv4 address 192.168.0.193 for interface "ens33".
I0521 17:47:42.263651   35253 interface.go:443] Found active IP 192.168.0.193 
I0521 17:47:42.263664   35253 kubelet.go:196] the value of KubeletConfiguration.cgroupDriver is empty; setting it to "systemd"
I0521 17:47:42.269997   35253 version.go:187] fetching Kubernetes version from URL: https://dl.k8s.io/release/stable-1.txt
[init] Using Kubernetes version: v1.30.1
[preflight] Running pre-flight checks
I0521 17:47:50.791989   35253 checks.go:561] validating Kubernetes and kubeadm version
I0521 17:47:50.792677   35253 checks.go:166] validating if the firewall is enabled and active
I0521 17:47:50.837349   35253 checks.go:201] validating availability of port 6443
I0521 17:47:50.837819   35253 checks.go:201] validating availability of port 10259
I0521 17:47:50.837884   35253 checks.go:201] validating availability of port 10257
I0521 17:47:50.837928   35253 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-apiserver.yaml
I0521 17:47:50.837948   35253 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-controller-manager.yaml
I0521 17:47:50.837962   35253 checks.go:278] validating the existence of file /etc/kubernetes/manifests/kube-scheduler.yaml
I0521 17:47:50.837972   35253 checks.go:278] validating the existence of file /etc/kubernetes/manifests/etcd.yaml
I0521 17:47:50.837983   35253 checks.go:428] validating if the connectivity type is via proxy or direct
I0521 17:47:50.838006   35253 checks.go:467] validating http connectivity to first IP address in the CIDR
I0521 17:47:50.838026   35253 checks.go:467] validating http connectivity to first IP address in the CIDR
I0521 17:47:50.838040   35253 checks.go:102] validating the container runtime
I0521 17:47:50.868314   35253 checks.go:637] validating whether swap is enabled or not
I0521 17:47:50.868418   35253 checks.go:368] validating the presence of executable crictl
I0521 17:47:50.868474   35253 checks.go:368] validating the presence of executable conntrack
I0521 17:47:50.868490   35253 checks.go:368] validating the presence of executable ip
I0521 17:47:50.868516   35253 checks.go:368] validating the presence of executable iptables
I0521 17:47:50.868532   35253 checks.go:368] validating the presence of executable mount
I0521 17:47:50.868546   35253 checks.go:368] validating the presence of executable nsenter
I0521 17:47:50.868559   35253 checks.go:368] validating the presence of executable ebtables
I0521 17:47:50.868574   35253 checks.go:368] validating the presence of executable ethtool
I0521 17:47:50.868585   35253 checks.go:368] validating the presence of executable socat
I0521 17:47:50.868599   35253 checks.go:368] validating the presence of executable tc
I0521 17:47:50.868610   35253 checks.go:368] validating the presence of executable touch
I0521 17:47:50.868625   35253 checks.go:514] running all checks
I0521 17:47:50.881898   35253 checks.go:399] checking whether the given node name is valid and reachable using net.LookupHost
I0521 17:47:50.882002   35253 checks.go:603] validating kubelet version
I0521 17:47:50.940180   35253 checks.go:128] validating if the "kubelet" service is enabled and active
I0521 17:47:50.955953   35253 checks.go:201] validating availability of port 10250
I0521 17:47:50.956060   35253 checks.go:327] validating the contents of file /proc/sys/net/ipv4/ip_forward
I0521 17:47:50.956212   35253 checks.go:201] validating availability of port 2379
I0521 17:47:50.956266   35253 checks.go:201] validating availability of port 2380
I0521 17:47:50.956370   35253 checks.go:241] validating the existence and emptiness of directory /var/lib/etcd
[preflight] Pulling images required for setting up a Kubernetes cluster
[preflight] This might take a minute or two, depending on the speed of your internet connection
[preflight] You can also perform this action in beforehand using 'kubeadm config images pull'
I0521 17:47:50.956702   35253 checks.go:830] using image pull policy: IfNotPresent
W0521 17:47:50.982457   35253 checks.go:844] detected that the sandbox image "registry.k8s.io/pause:3.6" of the container runtime is inconsistent with that used by kubeadm.It is recommended to use "registry.k8s.io/pause:3.9" as the CRI sandbox image.
I0521 17:47:51.008059   35253 checks.go:862] image exists: registry.k8s.io/kube-apiserver:v1.30.1
I0521 17:47:51.033849   35253 checks.go:862] image exists: registry.k8s.io/kube-controller-manager:v1.30.1
I0521 17:47:51.062030   35253 checks.go:862] image exists: registry.k8s.io/kube-scheduler:v1.30.1
I0521 17:47:51.087483   35253 checks.go:862] image exists: registry.k8s.io/kube-proxy:v1.30.1
I0521 17:47:51.112770   35253 checks.go:862] image exists: registry.k8s.io/coredns/coredns:v1.11.1
I0521 17:47:51.139221   35253 checks.go:862] image exists: registry.k8s.io/pause:3.9
I0521 17:47:51.165236   35253 checks.go:862] image exists: registry.k8s.io/etcd:3.5.12-0
[certs] Using certificateDir folder "/etc/kubernetes/pki"
I0521 17:47:51.165645   35253 certs.go:112] creating a new certificate authority for ca
[certs] Generating "ca" certificate and key
I0521 17:47:51.526590   35253 certs.go:483] validating certificate period for ca certificate
[certs] Generating "apiserver" certificate and key
[certs] apiserver serving cert is signed for DNS names [kubernetes kubernetes.default kubernetes.default.svc kubernetes.default.svc.cluster.local master] and IPs [10.96.0.1 192.168.0.193]
[certs] Generating "apiserver-kubelet-client" certificate and key
I0521 17:47:51.900812   35253 certs.go:112] creating a new certificate authority for front-proxy-ca
[certs] Generating "front-proxy-ca" certificate and key
I0521 17:47:52.164997   35253 certs.go:483] validating certificate period for front-proxy-ca certificate
[certs] Generating "front-proxy-client" certificate and key
I0521 17:47:52.361058   35253 certs.go:112] creating a new certificate authority for etcd-ca
[certs] Generating "etcd/ca" certificate and key
I0521 17:47:52.468817   35253 certs.go:483] validating certificate period for etcd/ca certificate
[certs] Generating "etcd/server" certificate and key
[certs] etcd/server serving cert is signed for DNS names [localhost master] and IPs [192.168.0.193 127.0.0.1 ::1]
[certs] Generating "etcd/peer" certificate and key
[certs] etcd/peer serving cert is signed for DNS names [localhost master] and IPs [192.168.0.193 127.0.0.1 ::1]
[certs] Generating "etcd/healthcheck-client" certificate and key
[certs] Generating "apiserver-etcd-client" certificate and key
I0521 17:47:53.048475   35253 certs.go:78] creating new public/private key files for signing service account users
[certs] Generating "sa" key and public key
[kubeconfig] Using kubeconfig folder "/etc/kubernetes"
I0521 17:47:53.214683   35253 kubeconfig.go:112] creating kubeconfig file for admin.conf
[kubeconfig] Writing "admin.conf" kubeconfig file
I0521 17:47:53.443788   35253 kubeconfig.go:112] creating kubeconfig file for super-admin.conf
[kubeconfig] Writing "super-admin.conf" kubeconfig file
I0521 17:47:53.625854   35253 kubeconfig.go:112] creating kubeconfig file for kubelet.conf
[kubeconfig] Writing "kubelet.conf" kubeconfig file
I0521 17:47:53.965875   35253 kubeconfig.go:112] creating kubeconfig file for controller-manager.conf
[kubeconfig] Writing "controller-manager.conf" kubeconfig file
I0521 17:47:54.065512   35253 kubeconfig.go:112] creating kubeconfig file for scheduler.conf
[kubeconfig] Writing "scheduler.conf" kubeconfig file
[etcd] Creating static Pod manifest for local etcd in "/etc/kubernetes/manifests"
I0521 17:47:54.214770   35253 local.go:65] [etcd] wrote Static Pod manifest for a local etcd member to "/etc/kubernetes/manifests/etcd.yaml"
[control-plane] Using manifest folder "/etc/kubernetes/manifests"
[control-plane] Creating static Pod manifest for "kube-apiserver"
I0521 17:47:54.215375   35253 manifests.go:103] [control-plane] getting StaticPodSpecs
I0521 17:47:54.215700   35253 certs.go:483] validating certificate period for CA certificate
I0521 17:47:54.216122   35253 manifests.go:129] [control-plane] adding volume "ca-certs" for component "kube-apiserver"
I0521 17:47:54.216139   35253 manifests.go:129] [control-plane] adding volume "etc-ca-certificates" for component "kube-apiserver"
I0521 17:47:54.216148   35253 manifests.go:129] [control-plane] adding volume "k8s-certs" for component "kube-apiserver"
I0521 17:47:54.216180   35253 manifests.go:129] [control-plane] adding volume "usr-local-share-ca-certificates" for component "kube-apiserver"
I0521 17:47:54.216190   35253 manifests.go:129] [control-plane] adding volume "usr-share-ca-certificates" for component "kube-apiserver"
I0521 17:47:54.216715   35253 manifests.go:158] [control-plane] wrote static Pod manifest for component "kube-apiserver" to "/etc/kubernetes/manifests/kube-apiserver.yaml"
[control-plane] Creating static Pod manifest for "kube-controller-manager"
I0521 17:47:54.217422   35253 manifests.go:103] [control-plane] getting StaticPodSpecs
I0521 17:47:54.217757   35253 manifests.go:129] [control-plane] adding volume "ca-certs" for component "kube-controller-manager"
I0521 17:47:54.217765   35253 manifests.go:129] [control-plane] adding volume "etc-ca-certificates" for component "kube-controller-manager"
I0521 17:47:54.217769   35253 manifests.go:129] [control-plane] adding volume "flexvolume-dir" for component "kube-controller-manager"
I0521 17:47:54.217773   35253 manifests.go:129] [control-plane] adding volume "k8s-certs" for component "kube-controller-manager"
I0521 17:47:54.217777   35253 manifests.go:129] [control-plane] adding volume "kubeconfig" for component "kube-controller-manager"
I0521 17:47:54.217781   35253 manifests.go:129] [control-plane] adding volume "usr-local-share-ca-certificates" for component "kube-controller-manager"
I0521 17:47:54.217785   35253 manifests.go:129] [control-plane] adding volume "usr-share-ca-certificates" for component "kube-controller-manager"
I0521 17:47:54.218322   35253 manifests.go:158] [control-plane] wrote static Pod manifest for component "kube-controller-manager" to "/etc/kubernetes/manifests/kube-controller-manager.yaml"
[control-plane] Creating static Pod manifest for "kube-scheduler"
I0521 17:47:54.218335   35253 manifests.go:103] [control-plane] getting StaticPodSpecs
I0521 17:47:54.218447   35253 manifests.go:129] [control-plane] adding volume "kubeconfig" for component "kube-scheduler"
I0521 17:47:54.218726   35253 manifests.go:158] [control-plane] wrote static Pod manifest for component "kube-scheduler" to "/etc/kubernetes/manifests/kube-scheduler.yaml"
I0521 17:47:54.218735   35253 kubelet.go:68] Stopping the kubelet
[kubelet-start] Writing kubelet environment file with flags to file "/var/lib/kubelet/kubeadm-flags.env"
[kubelet-start] Writing kubelet configuration to file "/var/lib/kubelet/config.yaml"
[kubelet-start] Starting the kubelet
[wait-control-plane] Waiting for the kubelet to boot up the control plane as static Pods from directory "/etc/kubernetes/manifests"
[kubelet-check] Waiting for a healthy kubelet. This can take up to 4m0s
[kubelet-check] The kubelet is healthy after 1.00390989s
[api-check] Waiting for a healthy API server. This can take up to 4m0s
[api-check] The API server is healthy after 3.50195798s
I0521 17:47:59.025259   35253 kubeconfig.go:608] ensuring that the ClusterRoleBinding for the kubeadm:cluster-admins Group exists
I0521 17:47:59.027633   35253 kubeconfig.go:681] creating the ClusterRoleBinding for the kubeadm:cluster-admins Group by using super-admin.conf
I0521 17:47:59.039135   35253 uploadconfig.go:112] [upload-config] Uploading the kubeadm ClusterConfiguration to a ConfigMap
[upload-config] Storing the configuration used in ConfigMap "kubeadm-config" in the "kube-system" Namespace
I0521 17:47:59.056482   35253 uploadconfig.go:126] [upload-config] Uploading the kubelet component config to a ConfigMap
[kubelet] Creating a ConfigMap "kubelet-config" in namespace kube-system with the configuration for the kubelets in the cluster
I0521 17:47:59.082697   35253 uploadconfig.go:131] [upload-config] Preserving the CRISocket information for the control-plane node
I0521 17:47:59.082834   35253 patchnode.go:31] [patchnode] Uploading the CRI Socket information "unix:///var/run/containerd/containerd.sock" to the Node API object "master" as an annotation
[upload-certs] Skipping phase. Please see --upload-certs
[mark-control-plane] Marking the node master as control-plane by adding the labels: [node-role.kubernetes.io/control-plane node.kubernetes.io/exclude-from-external-load-balancers]
[mark-control-plane] Marking the node master as control-plane by adding the taints [node-role.kubernetes.io/control-plane:NoSchedule]
[bootstrap-token] Using token: vxar9m.fi3ay6npn90xoyus
[bootstrap-token] Configuring bootstrap tokens, cluster-info ConfigMap, RBAC Roles
[bootstrap-token] Configured RBAC rules to allow Node Bootstrap tokens to get nodes
[bootstrap-token] Configured RBAC rules to allow Node Bootstrap tokens to post CSRs in order for nodes to get long term certificate credentials
[bootstrap-token] Configured RBAC rules to allow the csrapprover controller automatically approve CSRs from a Node Bootstrap Token
[bootstrap-token] Configured RBAC rules to allow certificate rotation for all node client certificates in the cluster
[bootstrap-token] Creating the "cluster-info" ConfigMap in the "kube-public" namespace
I0521 17:47:59.127187   35253 clusterinfo.go:47] [bootstrap-token] loading admin kubeconfig
I0521 17:47:59.127574   35253 clusterinfo.go:58] [bootstrap-token] copying the cluster from admin.conf to the bootstrap kubeconfig
I0521 17:47:59.128344   35253 clusterinfo.go:70] [bootstrap-token] creating/updating ConfigMap in kube-public namespace
I0521 17:47:59.132326   35253 clusterinfo.go:84] creating the RBAC rules for exposing the cluster-info ConfigMap in the kube-public namespace
I0521 17:47:59.226048   35253 request.go:629] Waited for 93.502034ms due to client-side throttling, not priority and fairness, request: POST:https://192.168.0.193:6443/apis/rbac.authorization.k8s.io/v1/namespaces/kube-public/roles?timeout=10s
I0521 17:47:59.426536   35253 request.go:629] Waited for 185.770709ms due to client-side throttling, not priority and fairness, request: POST:https://192.168.0.193:6443/apis/rbac.authorization.k8s.io/v1/namespaces/kube-public/rolebindings?timeout=10s
I0521 17:47:59.432196   35253 kubeletfinalize.go:91] [kubelet-finalize] Assuming that kubelet client certificate rotation is enabled: found "/var/lib/kubelet/pki/kubelet-client-current.pem"
[kubelet-finalize] Updating "/etc/kubernetes/kubelet.conf" to point to a rotatable kubelet client certificate and key
I0521 17:47:59.433233   35253 kubeletfinalize.go:145] [kubelet-finalize] Restarting the kubelet to enable client certificate rotation
[addons] Applied essential addon: CoreDNS
I0521 17:48:00.040506   35253 request.go:629] Waited for 170.3063ms due to client-side throttling, not priority and fairness, request: POST:https://192.168.0.193:6443/api/v1/namespaces/kube-system/serviceaccounts?timeout=10s
I0521 17:48:00.226775   35253 request.go:629] Waited for 179.490915ms due to client-side throttling, not priority and fairness, request: POST:https://192.168.0.193:6443/apis/rbac.authorization.k8s.io/v1/namespaces/kube-system/roles?timeout=10s
I0521 17:48:00.426505   35253 request.go:629] Waited for 194.572588ms due to client-side throttling, not priority and fairness, request: POST:https://192.168.0.193:6443/apis/rbac.authorization.k8s.io/v1/namespaces/kube-system/rolebindings?timeout=10s
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

kubeadm join 192.168.0.193:6443 --token vxar9m.fi3ay6npn90xoyus \
	--discovery-token-ca-cert-hash sha256:80a0e5d6958f7c070e5493882d4856b485b8a8ac28ddb2567bef0e8c8d94dcac 
master@master:~$ mkdir -p $HOME/.kube
master@master:~$ sudo cp -i /etc/kubernetes/admin.conf $HOME/.kube/config
cp: overwrite '/home/master/.kube/config'? 
master@master:~$ sudo chown $(id -u):$(id -g) $HOME/.kube/config
master@master:~$ export KUBECONFIG=/etc/kubernetes/admin.conf
master@master:~$ kubectl get nodes
error: error loading config file "/etc/kubernetes/admin.conf": open /etc/kubernetes/admin.conf: permission denied
master@master:~$ sudo chmod -R 777 /etc/kubernetes/*
master@master:~$ kubectl get nodes
NAME      STATUS   ROLES           AGE     VERSION
master    Ready    control-plane   4m10s   v1.30.1
worker1   Ready    <none>          35s     v1.30.1
master@master:~$ watch kubectl get pods -n calico-system
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
master@master:~$ kubectl taint nodes --all node-role.kubernetes.io/control-plane-
node/master untainted
error: taint "node-role.kubernetes.io/control-plane" not found
master@master:~$ kubectl get nodes -o wide
NAME      STATUS   ROLES           AGE     VERSION   INTERNAL-IP     EXTERNAL-IP   OS-IMAGE           KERNEL-VERSION     CONTAINER-RUNTIME
master    Ready    control-plane   8m1s    v1.30.1   192.168.0.193   <none>        Ubuntu 24.04 LTS   6.8.0-31-generic   containerd://1.6.31
worker1   Ready    <none>          4m26s   v1.30.1   192.168.0.143   <none>        Ubuntu 24.04 LTS   6.8.0-31-generic   containerd://1.6.31
master@master:~$ kubectl apply -f 
.bash_history              .cache/                    .ssh/                      .wget-hsts                 kubectl                    
.bash_logout               .kube/                     .sudo_as_admin_successful  custom-resources.yaml      kubectl.sha256             
.bashrc                    .profile                   .viminfo                   hello-pod.yml              tigera-operator.yaml       
master@master:~$ kubectl apply -f hello-pod.yml 
pod/hello-pod created
master@master:~$ kubectl get pods
NAME        READY   STATUS              RESTARTS   AGE
hello-pod   0/1     ContainerCreating   0          9s
master@master:~$ kubectl get pods
NAME        READY   STATUS              RESTARTS   AGE
hello-pod   0/1     ContainerCreating   0          11s
master@master:~$ kubectl get pods
NAME        READY   STATUS              RESTARTS   AGE
hello-pod   0/1     ContainerCreating   0          12s
master@master:~$ kubectl get pods
NAME        READY   STATUS              RESTARTS   AGE
hello-pod   0/1     ContainerCreating   0          13s
master@master:~$ kubectl get pods
NAME        READY   STATUS              RESTARTS   AGE
hello-pod   0/1     ContainerCreating   0          14s
master@master:~$ kubectl get pods
NAME        READY   STATUS              RESTARTS   AGE
hello-pod   0/1     ContainerCreating   0          15s
master@master:~$ kubectl get pods
NAME        READY   STATUS              RESTARTS   AGE
hello-pod   0/1     ContainerCreating   0          15s
master@master:~$ kubectl get pods
NAME        READY   STATUS              RESTARTS   AGE
hello-pod   0/1     ContainerCreating   0          17s
master@master:~$ kubectl get pods
NAME        READY   STATUS              RESTARTS   AGE
hello-pod   0/1     ContainerCreating   0          18s
master@master:~$ kubectl get pods
NAME        READY   STATUS              RESTARTS   AGE
hello-pod   0/1     ContainerCreating   0          20s
master@master:~$ kubectl get pods
NAME        READY   STATUS              RESTARTS   AGE
hello-pod   0/1     ContainerCreating   0          21s
master@master:~$ kubectl get pods
NAME        READY   STATUS              RESTARTS   AGE
hello-pod   0/1     ContainerCreating   0          22s
master@master:~$ kubectl get pods
NAME        READY   STATUS              RESTARTS   AGE
hello-pod   0/1     ContainerCreating   0          22s
master@master:~$ kubectl get pods
NAME        READY   STATUS              RESTARTS   AGE
hello-pod   0/1     ContainerCreating   0          23s
master@master:~$ kubectl get pods
NAME        READY   STATUS    RESTARTS   AGE
hello-pod   1/1     Running   0          24s
master@master:~$ kubectl get pods
NAME        READY   STATUS    RESTARTS   AGE
hello-pod   1/1     Running   0          26s
master@master:~$ kubectl cluster-info
Kubernetes control plane is running at https://192.168.0.193:6443
CoreDNS is running at https://192.168.0.193:6443/api/v1/namespaces/kube-system/services/kube-dns:dns/proxy

To further debug and diagnose cluster problems, use 'kubectl cluster-info dump'.
master@master:~$ kubectl apply -f https://k8s.io/examples/pods/commands.yaml
pod/command-demo created
master@master:~$ kubectl get pods
NAME           READY   STATUS              RESTARTS   AGE
command-demo   0/1     ContainerCreating   0          3s
hello-pod      1/1     Running             0          2m49s
master@master:~$ kubectl get pods
NAME           READY   STATUS              RESTARTS   AGE
command-demo   0/1     ContainerCreating   0          5s
hello-pod      1/1     Running             0          2m51s
master@master:~$ kubectl get pods
NAME           READY   STATUS              RESTARTS   AGE
command-demo   0/1     ContainerCreating   0          6s
hello-pod      1/1     Running             0          2m52s
master@master:~$ kubectl get pods
NAME           READY   STATUS              RESTARTS   AGE
command-demo   0/1     ContainerCreating   0          7s
hello-pod      1/1     Running             0          2m53s
master@master:~$ kubectl get pods
NAME           READY   STATUS              RESTARTS   AGE
command-demo   0/1     ContainerCreating   0          8s
hello-pod      1/1     Running             0          2m54s
master@master:~$ kubectl get pods
NAME           READY   STATUS              RESTARTS   AGE
command-demo   0/1     ContainerCreating   0          9s
hello-pod      1/1     Running             0          2m55s
master@master:~$ kubectl get pods
NAME           READY   STATUS              RESTARTS   AGE
command-demo   0/1     ContainerCreating   0          10s
hello-pod      1/1     Running             0          2m56s
master@master:~$ kubectl get pods
NAME           READY   STATUS              RESTARTS   AGE
command-demo   0/1     ContainerCreating   0          11s
hello-pod      1/1     Running             0          2m57s
master@master:~$ kubectl get pods
NAME           READY   STATUS              RESTARTS   AGE
command-demo   0/1     ContainerCreating   0          12s
hello-pod      1/1     Running             0          2m58s
master@master:~$ kubectl get pods
NAME           READY   STATUS              RESTARTS   AGE
command-demo   0/1     ContainerCreating   0          13s
hello-pod      1/1     Running             0          2m59s
master@master:~$ kubectl get pods
NAME           READY   STATUS              RESTARTS   AGE
command-demo   0/1     ContainerCreating   0          14s
hello-pod      1/1     Running             0          3m
master@master:~$ kubectl get pods
NAME           READY   STATUS              RESTARTS   AGE
command-demo   0/1     ContainerCreating   0          15s
hello-pod      1/1     Running             0          3m1s
master@master:~$ kubectl get pods
NAME           READY   STATUS              RESTARTS   AGE
command-demo   0/1     ContainerCreating   0          16s
hello-pod      1/1     Running             0          3m2s
master@master:~$ kubectl get pods
NAME           READY   STATUS              RESTARTS   AGE
command-demo   0/1     ContainerCreating   0          18s
hello-pod      1/1     Running             0          3m4s
master@master:~$ kubectl get pods
NAME           READY   STATUS              RESTARTS   AGE
command-demo   0/1     ContainerCreating   0          19s
hello-pod      1/1     Running             0          3m5s
master@master:~$ kubectl get pods
NAME           READY   STATUS              RESTARTS   AGE
command-demo   0/1     ContainerCreating   0          20s
hello-pod      1/1     Running             0          3m6s
master@master:~$ kubectl get pods
NAME           READY   STATUS              RESTARTS   AGE
command-demo   0/1     ContainerCreating   0          21s
hello-pod      1/1     Running             0          3m7s
master@master:~$ kubectl get pods
NAME           READY   STATUS              RESTARTS   AGE
command-demo   0/1     ContainerCreating   0          23s
hello-pod      1/1     Running             0          3m9s
master@master:~$ kubectl get pods
NAME           READY   STATUS              RESTARTS   AGE
command-demo   0/1     ContainerCreating   0          24s
hello-pod      1/1     Running             0          3m10s
master@master:~$ kubectl get pods
NAME           READY   STATUS              RESTARTS   AGE
command-demo   0/1     ContainerCreating   0          26s
hello-pod      1/1     Running             0          3m12s
master@master:~$ kubectl get pods
NAME           READY   STATUS      RESTARTS   AGE
command-demo   0/1     Completed   0          78s
hello-pod      1/1     Running     0          4m4s
master@master:~$ kubectl get pods
NAME           READY   STATUS      RESTARTS   AGE
command-demo   0/1     Completed   0          82s
hello-pod      1/1     Running     0          4m8s
master@master:~$ kubectl get pods
NAME           READY   STATUS      RESTARTS   AGE
command-demo   0/1     Completed   0          84s
hello-pod      1/1     Running     0          4m10s
master@master:~$ kubectl get pods
NAME           READY   STATUS      RESTARTS   AGE
command-demo   0/1     Completed   0          85s
hello-pod      1/1     Running     0          4m11s
master@master:~$ kubectl get pods
NAME           READY   STATUS      RESTARTS   AGE
command-demo   0/1     Completed   0          86s
hello-pod      1/1     Running     0          4m12s
master@master:~$ kubectl get pods
NAME           READY   STATUS      RESTARTS   AGE
command-demo   0/1     Completed   0          87s
hello-pod      1/1     Running     0          4m13s
master@master:~$ kubectl get pods
NAME           READY   STATUS      RESTARTS   AGE
command-demo   0/1     Completed   0          88s
hello-pod      1/1     Running     0          4m14s
master@master:~$ kubectl get pods
NAME           READY   STATUS      RESTARTS   AGE
command-demo   0/1     Completed   0          90s
hello-pod      1/1     Running     0          4m16s
master@master:~$ kubectl get pods
NAME           READY   STATUS      RESTARTS   AGE
command-demo   0/1     Completed   0          91s
hello-pod      1/1     Running     0          4m17s
master@master:~$ kubectl get pods
NAME           READY   STATUS      RESTARTS   AGE
command-demo   0/1     Completed   0          92s
hello-pod      1/1     Running     0          4m18s
master@master:~$ kubectl get pods
NAME           READY   STATUS      RESTARTS   AGE
command-demo   0/1     Completed   0          93s
hello-pod      1/1     Running     0          4m19s
master@master:~$ kubectl get pods
NAME           READY   STATUS      RESTARTS   AGE
command-demo   0/1     Completed   0          94s
hello-pod      1/1     Running     0          4m20s
master@master:~$ 




master@master:~$ curl https://baltocdn.com/helm/signing.asc | gpg --dearmor | sudo tee /usr/share/keyrings/helm.gpg > /dev/null
[sudo] password for master:   % Total    % Received % Xferd  Average Speed   Time    Time     Time  Current
                                 Dload  Upload   Total   Spent    Left  Speed
100  1699  100  1699    0     0   7763      0 --:--:-- --:--:-- --:--:--  7757

Sorry, try again.
[sudo] password for master: 
master@master:~$ echo "deb [arch=$(dpkg --print-architecture) signed-by=/usr/share/keyrings/helm.gpg] https://baltocdn.com/helm/stable/debian/ all main" | sudo tee /etc/apt/sources.list.d/helm-stable-debian.list
deb [arch=amd64 signed-by=/usr/share/keyrings/helm.gpg] https://baltocdn.com/helm/stable/debian/ all main
master@master:~$ sudo apt-get update
Get:1 https://baltocdn.com/helm/stable/debian all InRelease [7652 B]
Get:2 https://baltocdn.com/helm/stable/debian all/main amd64 Packages [4108 B]                                                                        
Hit:3 https://prod-cdn.packages.k8s.io/repositories/isv:/kubernetes:/core:/stable:/v1.30/deb  InRelease                                                          
Hit:4 https://download.docker.com/linux/ubuntu noble InRelease                                                                        
Hit:5 http://security.ubuntu.com/ubuntu noble-security InRelease                                                
Hit:6 http://bd.archive.ubuntu.com/ubuntu noble InRelease                                                                                                                               
Get:7 http://bd.archive.ubuntu.com/ubuntu noble-updates InRelease [89.7 kB]                                                                                                             
Hit:8 http://bd.archive.ubuntu.com/ubuntu noble-backports InRelease                                                                                                                     
Get:9 http://bd.archive.ubuntu.com/ubuntu noble-updates/main amd64 Packages [35.5 kB]                                                                                                   
Get:10 http://bd.archive.ubuntu.com/ubuntu noble-updates/main Translation-en [11.4 kB]                                                                                                  
Get:11 http://bd.archive.ubuntu.com/ubuntu noble-updates/universe amd64 Packages [21.0 kB]                                                                                              
Get:12 http://bd.archive.ubuntu.com/ubuntu noble-updates/universe Translation-en [7368 B]                                                                                               
Fetched 177 kB in 16s (11.3 kB/s)                                                                                                                                                       
Reading package lists... Done
master@master:~$ sudo apt-get install helm
Reading package lists... Done
Building dependency tree... Done
Reading state information... Done
The following NEW packages will be installed:
  helm
0 upgraded, 1 newly installed, 0 to remove and 7 not upgraded.
Need to get 16.6 MB of archives.
After this operation, 52.5 MB of additional disk space will be used.
Get:1 https://baltocdn.com/helm/stable/debian all/main amd64 helm amd64 3.15.0-1 [16.6 MB]
Fetched 16.6 MB in 7s (2222 kB/s)                                                                                                                                                       
debconf: delaying package configuration, since apt-utils is not installed
Selecting previously unselected package helm.
(Reading database ... 77992 files and directories currently installed.)
Preparing to unpack .../helm_3.15.0-1_amd64.deb ...
Unpacking helm (3.15.0-1) ...
Setting up helm (3.15.0-1) ...
Scanning processes...                                                                                                                                                                    
Scanning linux images...                                                                                                                                                                 

Running kernel seems to be up-to-date.

No services need to be restarted.

No containers need to be restarted.

No user sessions are running outdated binaries.

No VM guests are running outdated hypervisor (qemu) binaries on this host.
master@master:~$ helm repo add kubernetes-dashboard https://kubernetes.github.io/dashboard/
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
"kubernetes-dashboard" has been added to your repositories
master@master:~$ helm upgrade --install kubernetes-dashboard kubernetes-dashboard/kubernetes-dashboard --create-namespace --namespace kubernetes-dashboard
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
Release "kubernetes-dashboard" does not exist. Installing it now.
NAME: kubernetes-dashboard
LAST DEPLOYED: Tue May 21 18:38:36 2024
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
master@master:~$ kubectl -n kubernetes-dashboard port-forward svc/kubernetes-dashboard-kong-proxy 8443:443
error: unable to forward port because pod is not running. Current status=Pending
master@master:~$ kubectl -n kubernetes-dashboard port-forward svc/kubernetes-dashboard-kong-proxy 8443:443
error: unable to forward port because pod is not running. Current status=Pending
master@master:~$ kubectl -n kubernetes-dashboard get svc
NAME                                   TYPE        CLUSTER-IP       EXTERNAL-IP   PORT(S)                         AGE
kubernetes-dashboard-api               ClusterIP   10.108.142.204   <none>        8000/TCP                        72s
kubernetes-dashboard-auth              ClusterIP   10.98.183.98     <none>        8000/TCP                        72s
kubernetes-dashboard-kong-manager      NodePort    10.96.83.34      <none>        8002:30278/TCP,8445:31679/TCP   72s
kubernetes-dashboard-kong-proxy        ClusterIP   10.109.168.68    <none>        443/TCP                         72s
kubernetes-dashboard-metrics-scraper   ClusterIP   10.98.85.143     <none>        8000/TCP                        72s
kubernetes-dashboard-web               ClusterIP   10.108.221.125   <none>        8000/TCP                        72s
master@master:~$ kubectl -n kubernetes-dashboard get svc
NAME                                   TYPE        CLUSTER-IP       EXTERNAL-IP   PORT(S)                         AGE
kubernetes-dashboard-api               ClusterIP   10.108.142.204   <none>        8000/TCP                        2m18s
kubernetes-dashboard-auth              ClusterIP   10.98.183.98     <none>        8000/TCP                        2m18s
kubernetes-dashboard-kong-manager      NodePort    10.96.83.34      <none>        8002:30278/TCP,8445:31679/TCP   2m18s
kubernetes-dashboard-kong-proxy        ClusterIP   10.109.168.68    <none>        443/TCP                         2m18s
kubernetes-dashboard-metrics-scraper   ClusterIP   10.98.85.143     <none>        8000/TCP                        2m18s
kubernetes-dashboard-web               ClusterIP   10.108.221.125   <none>        8000/TCP                        2m18s
master@master:~$ kubectl -n kubernetes-dashboard port-forward svc/kubernetes-dashboard-kong-proxy 8443:443
error: unable to forward port because pod is not running. Current status=Pending
master@master:~$ kubectl -n kubernetes-dashboard port-forward svc/kubernetes-dashboard-kong-proxy 8443:443
error: unable to forward port because pod is not running. Current status=Pending
master@master:~$ 

