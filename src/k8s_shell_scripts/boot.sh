# !/bin/bash

# reset kubeadm
sudo kubeadm reset -f

# init kubeadm
sudo kubeadm init --pod-network-cidr=192.168.0.0/16 --cri-socket=/var/run/containerd/containerd.sock --control-plane-endpoint=k8s-cluster.mehmet.com --v=5

# post init
mkdir -p $HOME/.kube
sudo cp -i /etc/kubernetes/admin.conf $HOME/.kube/config
sudo chown $(id -u):$(id -g) $HOME/.kube/config

export KUBECONFIG=/etc/kubernetes/admin.conf

# set permissions
sudo chmod -R 755 /etc/kubernetes/admin.conf

# calico
kubectl create -f https://raw.githubusercontent.com/projectcalico/calico/v3.28.0/manifests/tigera-operator.yaml

kubectl create -f https://raw.githubusercontent.com/projectcalico/calico/v3.28.0/manifests/custom-resources.yaml

watch kubectl get pods -n calico-system

kubectl get nodes -o wide

kubectl apply -f hello-pod.yaml

kubectl get pods -o wide

# kubernetes dashboard
helm repo add kubernetes-dashboard https://kubernetes.github.io/dashboard/
helm upgrade --install kubernetes-dashboard kubernetes-dashboard/kubernetes-dashboard --create-namespace --namespace kubernetes-dashboard

kubectl -n kubernetes-dashboard get svc -o wide

kubectl apply -f dashboard-adminuser.yaml

kubectl apply -f cluster-role.yaml

kubectl -n kubernetes-dashboard create token admin-user

# port forward by screen
screen -S kubernetes-dashboard

kubectl -n kubernetes-dashboard port-forward --address 0.0.0.0 svc/kubernetes-dashboard-kong-proxy 8443:443


# Prometheus-Stack
helm install kube-prometheus-stack-58 prometheus-community/kube-prometheus-stack

kubectl --namespace default get pods -l "release=kube-prometheus-stack-58"

# port forward by screen
screen -S kubernetes-prometheus
kubectl port-forward -n default --address 0.0.0.0 svc/kube-prometheus-stack-58-prometheus 9090:9090

screen -S kubernetes-grafana
kubectl port-forward --address 0.0.0.0 -n default svc/kube-prometheus-stack-58-grafana 3000:80

Default user pass => admin/prom-operator


