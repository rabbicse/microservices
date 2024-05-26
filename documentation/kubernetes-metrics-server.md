# Kubernetes Metrics Server

Metrics Server is a scalable, efficient source of container resource metrics for Kubernetes
built-in autoscaling pipelines.

Metrics Server collects resource metrics from Kubelets and exposes them in Kubernetes apiserver through [Metrics API]
for use by [Horizontal Pod Autoscaler] and [Vertical Pod Autoscaler]. Metrics API can also be accessed by `kubectl top`,
making it easier to debug autoscaling pipelines.

> [!CAUTION]
> Metrics Server is meant only for autoscaling purposes. For example, don't use it to forward metrics to monitoring solutions, or as a source of monitoring solution metrics. In such cases please collect metrics from Kubelet `/metrics/resource` endpoint directly.

Metrics Server offers:
- A single deployment that works on most clusters (see [Requirements](#requirements))
- Fast autoscaling, collecting metrics every 15 seconds.
- Resource efficiency, using 1 mili core of CPU and 2 MB of memory for each node in a cluster.
- Scalable support up to 5,000 node clusters.

[Metrics API]: https://github.com/kubernetes/metrics
[Horizontal Pod Autoscaler]: https://kubernetes.io/docs/tasks/run-application/horizontal-pod-autoscale/
[Vertical Pod Autoscaler]: https://github.com/kubernetes/autoscaler/tree/master/vertical-pod-autoscaler/

## Use cases

You can use Metrics Server for:

- CPU/Memory based horizontal autoscaling (learn more about [Horizontal Autoscaling])
- Automatically adjusting/suggesting resources needed by containers (learn more about [Vertical Autoscaling])

Don't use Metrics Server when you need:

- Non-Kubernetes clusters
- An accurate source of resource usage metrics
- Horizontal autoscaling based on other resources than CPU/Memory

For unsupported use cases, check out full monitoring solutions like [Prometheus](https://github.com/prometheus/prometheus).

[Horizontal Autoscaling]: https://kubernetes.io/docs/tasks/run-application/horizontal-pod-autoscale/
[Vertical Autoscaling]: https://github.com/kubernetes/autoscaler/tree/master/vertical-pod-autoscaler/

## Requirements

Metrics Server has specific requirements for cluster and network configuration. These requirements aren't the default for all cluster
distributions. Please ensure that your cluster distribution supports these requirements before using Metrics Server:

- The kube-apiserver must [enable an aggregation layer].
- Nodes must have Webhook [authentication and authorization] enabled.
- Kubelet certificate needs to be signed by cluster Certificate Authority (or disable certificate validation by passing `--kubelet-insecure-tls` to Metrics Server)
- Container runtime must implement a [container metrics RPCs] (or have [cAdvisor] support)
- Network should support following communication:
  - Control plane to Metrics Server. Control plane node needs to reach Metrics Server's pod IP and port 10250 (or node IP and custom port if `hostNetwork` is enabled). Read more about [control plane to node communication](https://kubernetes.io/docs/concepts/architecture/control-plane-node-communication/#control-plane-to-node).
  - Metrics Server to Kubelet on all nodes. Metrics server needs to reach node address and Kubelet port. Addresses and ports are configured in Kubelet and published as part of Node object. Addresses in `.status.addresses` and port in `.status.daemonEndpoints.kubeletEndpoint.port` field (default 10250). Metrics Server will pick first node address based on the list provided by `kubelet-preferred-address-types` command line flag (default `InternalIP,ExternalIP,Hostname` in manifests).

[reachable from kube-apiserver]: https://kubernetes.io/docs/concepts/architecture/master-node-communication/#master-to-cluster
[enable an aggregation layer]: https://kubernetes.io/docs/tasks/access-kubernetes-api/configure-aggregation-layer/
[authentication and authorization]: https://kubernetes.io/docs/reference/access-authn-authz/kubelet-authn-authz/
[container metrics RPCs]: https://github.com/kubernetes/community/blob/master/contributors/devel/sig-node/cri-container-stats.md
[cAdvisor]: https://github.com/google/cadvisor

## Installation

Metrics Server can be installed either directly from YAML manifest or via the official [Helm chart](https://artifacthub.io/packages/helm/metrics-server/metrics-server). To install the latest Metrics Server release from the _components.yaml_ manifest, run the following command.

```shell
kubectl apply -f https://github.com/kubernetes-sigs/metrics-server/releases/latest/download/components.yaml
```

On terminal you should show the output like the following snippet

```shell
master@master:~$ kubectl apply -f https://github.com/kubernetes-sigs/metrics-server/releases/latest/download/components.yaml
serviceaccount/metrics-server created
clusterrole.rbac.authorization.k8s.io/system:aggregated-metrics-reader created
clusterrole.rbac.authorization.k8s.io/system:metrics-server created
rolebinding.rbac.authorization.k8s.io/metrics-server-auth-reader created
clusterrolebinding.rbac.authorization.k8s.io/metrics-server:system:auth-delegator created
clusterrolebinding.rbac.authorization.k8s.io/system:metrics-server created
service/metrics-server created
deployment.apps/metrics-server created
apiservice.apiregistration.k8s.io/v1beta1.metrics.k8s.io created
```

### High Availability

Metrics Server can be installed in high availability mode directly from a YAML manifest or via the official [Helm chart](https://artifacthub.io/packages/helm/metrics-server/metrics-server) by setting the `replicas` value greater than `1`. To install the latest Metrics Server release in high availability mode from the  _high-availability.yaml_ manifest, run the following command.

On Kubernetes v1.21+:

```
kubectl apply -f https://github.com/kubernetes-sigs/metrics-server/releases/latest/download/high-availability-1.21+.yaml
```

On terminal you should show the output like the following snippet.

```
master@master:~$ kubectl apply -f https://github.com/kubernetes-sigs/metrics-server/releases/latest/download/high-availability-1.21+.yaml
serviceaccount/metrics-server unchanged
clusterrole.rbac.authorization.k8s.io/system:aggregated-metrics-reader unchanged
clusterrole.rbac.authorization.k8s.io/system:metrics-server unchanged
rolebinding.rbac.authorization.k8s.io/metrics-server-auth-reader unchanged
clusterrolebinding.rbac.authorization.k8s.io/metrics-server:system:auth-delegator unchanged
clusterrolebinding.rbac.authorization.k8s.io/system:metrics-server unchanged
service/metrics-server unchanged
deployment.apps/metrics-server configured
poddisruptionbudget.policy/metrics-server created
apiservice.apiregistration.k8s.io/v1beta1.metrics.k8s.io unchanged
```

>[!NOTE]
> This configuration **requires** having a cluster with at least 2 nodes on which Metrics Server can be scheduled.

Also, to maximize the efficiency of this highly available configuration, it is **recommended** to add the `--enable-aggregator-routing=true` CLI flag to the kube-apiserver so that requests sent to Metrics Server are load balanced between the 2 instances.

## References
- https://github.com/kubernetes-sigs/metrics-server
- https://artifacthub.io/packages/helm/metrics-server/metrics-server
