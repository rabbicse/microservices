# Kubernetes Prometheus Stack
Installs the [kube-prometheus stack](https://github.com/prometheus-operator/kube-prometheus), a collection of Kubernetes manifests, [Grafana](http://grafana.com/) dashboards, and [Prometheus rules](https://prometheus.io/docs/prometheus/latest/configuration/recording_rules/) combined with documentation and scripts to provide easy to operate end-to-end Kubernetes cluster monitoring with [Prometheus](https://prometheus.io/) using the [Prometheus Operator](https://github.com/prometheus-operator/prometheus-operator).

See the [kube-prometheus](https://github.com/prometheus-operator/kube-prometheus) README for details about components, dashboards, and alerts.

_Note: This chart was formerly named `prometheus-operator` chart, now renamed to more clearly reflect that it installs the `kube-prometheus` project stack, within which Prometheus Operator is only one component._

## Prerequisites

- Kubernetes 1.19+
- Helm 3+

## Get Helm Repository Info

```console
helm repo add prometheus-community https://prometheus-community.github.io/helm-charts
helm repo update
```

_See [`helm repo`](https://helm.sh/docs/helm/helm_repo/) for command documentation._

## References
- [Kube Prometheus Stack](https://github.com/prometheus-community/helm-charts/blob/main/charts/kube-prometheus-stack/)
- [Install Prometheus and Grafana on Kubernetes using prometheus-operator](https://computingforgeeks.com/setup-prometheus-and-grafana-on-kubernetes/)
