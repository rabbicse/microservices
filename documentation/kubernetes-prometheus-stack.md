# Kubernetes Prometheus Stack
Installs the [kube-prometheus stack](https://github.com/prometheus-operator/kube-prometheus), a collection of Kubernetes manifests, [Grafana](http://grafana.com/) dashboards, and [Prometheus rules](https://prometheus.io/docs/prometheus/latest/configuration/recording_rules/) combined with documentation and scripts to provide easy to operate end-to-end Kubernetes cluster monitoring with [Prometheus](https://prometheus.io/) using the [Prometheus Operator](https://github.com/prometheus-operator/prometheus-operator).

See the [kube-prometheus](https://github.com/prometheus-operator/kube-prometheus) README for details about components, dashboards, and alerts.

_Note: This chart was formerly named `prometheus-operator` chart, now renamed to more clearly reflect that it installs the `kube-prometheus` project stack, within which Prometheus Operator is only one component._

## Prerequisites

- Kubernetes 1.19+
- Helm 3+

## Get Helm Repository Info

```shell
helm repo add prometheus-community https://prometheus-community.github.io/helm-charts
helm repo update
```

```shell
helm install kube-prometheus-stack-58 prometheus-community/kube-prometheus-stack
```

You should show the output like the following snippet.
```shell
master@master:~$ helm install kube-prometheus-stack-58 prometheus-community/kube-prometheus-stack
WARNING: Kubernetes configuration file is group-readable. This is insecure. Location: /etc/kubernetes/admin.conf
WARNING: Kubernetes configuration file is world-readable. This is insecure. Location: /etc/kubernetes/admin.conf
NAME: kube-prometheus-stack-58
LAST DEPLOYED: Tue May 28 16:55:06 2024
NAMESPACE: default
STATUS: deployed
REVISION: 1
NOTES:
kube-prometheus-stack has been installed. Check its status by running:
  kubectl --namespace default get pods -l "release=kube-prometheus-stack-58"

Visit https://github.com/prometheus-operator/kube-prometheus for instructions on how to create & configure Alertmanager and Prometheus instances using the Operator.
```

To check pods of prometheus-stack write the following command.

```
kubectl --namespace default get pods -l "release=kube-prometheus-stack-58"
```

You should show the output like the following snippet.
```
master@master:~$ kubectl --namespace default get pods -l "release=kube-prometheus-stack-58"
NAME                                                           READY   STATUS    RESTARTS   AGE
kube-prometheus-stack-58-kube-state-metrics-7567d9979b-4h8nq   1/1     Running   0          2m14s
kube-prometheus-stack-58-operator-dd57575f4-l5fcb              1/1     Running   0          2m14s
kube-prometheus-stack-58-prometheus-node-exporter-hklfd        1/1     Running   0          2m14s
kube-prometheus-stack-58-prometheus-node-exporter-njjg5        1/1     Running   0          2m14s
kube-prometheus-stack-58-prometheus-node-exporter-q8lbq        1/1     Running   0          2m14s
```


## References
- [Kube Prometheus Stack](https://github.com/prometheus-community/helm-charts/blob/main/charts/kube-prometheus-stack/)
- [Install Prometheus and Grafana on Kubernetes using prometheus-operator](https://computingforgeeks.com/setup-prometheus-and-grafana-on-kubernetes/)
