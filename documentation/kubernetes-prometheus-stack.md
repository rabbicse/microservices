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

Now write the following command to check all services under default namespace.

```
kubectl --namespace default get svc
```

You should see the output like the following snippet.
```
master@master:~$ kubectl --namespace default get svc
NAME                                                TYPE        CLUSTER-IP      EXTERNAL-IP   PORT(S)                      AGE
alertmanager-operated                               ClusterIP   None            <none>        9093/TCP,9094/TCP,9094/UDP   10m
kube-prometheus-stack-58-alertmanager               ClusterIP   10.97.207.14    <none>        9093/TCP,8080/TCP            10m
kube-prometheus-stack-58-grafana                    ClusterIP   10.102.87.51    <none>        80/TCP                       10m
kube-prometheus-stack-58-kube-state-metrics         ClusterIP   10.101.93.1     <none>        8080/TCP                     10m
kube-prometheus-stack-58-operator                   ClusterIP   10.103.215.7    <none>        443/TCP                      10m
kube-prometheus-stack-58-prometheus                 ClusterIP   10.109.199.14   <none>        9090/TCP,8080/TCP            10m
kube-prometheus-stack-58-prometheus-node-exporter   ClusterIP   10.108.6.112    <none>        9100/TCP                     10m
kubernetes                                          ClusterIP   10.96.0.1       <none>        443/TCP                      5h2m
prometheus-operated                                 ClusterIP   None            <none>        9090/TCP                     10m
```

I have used `screen` to forward ports in background. You can use `nohup` or anything similar to it to forward ports in background. 

### Access prometheus UI
Write the following command with screen name `kubernetes-prometheus`

```
screen -S kubernetes-prometheus
```

Then write the following command.

```
kubectl port-forward -n default --address 0.0.0.0 svc/kube-prometheus-stack-58-prometheus 9090:9090
```

You should see the output like the following snippet.

```
master@master:~$ kubectl port-forward -n default --address 0.0.0.0 svc/kube-prometheus-stack-58-prometheus 9090:9090
Forwarding from 0.0.0.0:9090 -> 9090
```

Detach from screen by `Ctrl+A+D`

Now browse the url: `http://<host-name>:9090` for my case it's `http://192.168.0.193:9090` You should see the screen like the following screenshot.

![image](https://github.com/rabbicse/microservices/blob/master/screenshots/kubernetes/kubernetes-prometheus.png)

### Access grafana UI
Write the following command with screen name `kubernetes-grafana`

```
screen -S kubernetes-grafana
```

Then write the following command.

```
kubectl port-forward --address 0.0.0.0 -n default svc/kube-prometheus-stack-58-grafana 3000:80
```

You should see the output like the following snippet.

```
master@master:~$ kubectl port-forward --address 0.0.0.0 -n default svc/kube-prometheus-stack-58-grafana 3000:80
Forwarding from 0.0.0.0:3000 -> 3000
```

Detach from screen by `Ctrl+A+D`

Now browse the url: `http://<host-name>:3000` for my case it's `http://192.168.0.193:3000` You should see the screen like the following screenshot.

![image](https://github.com/rabbicse/microservices/blob/master/screenshots/kubernetes/kubernetes-grafana.png)

Login with default user/password => `admin/prom-operator`.

### Access alert manager UI
Write the following command with screen name `kubernetes-prometheus`

```
screen -S kubernetes-alertmanager
```

Then write the following command.

```
kubectl port-forward --address 0.0.0.0 -n default svc/kube-prometheus-stack-58-alertmanager 9093:9093
```

You should see the output like the following snippet.

```master@master:~$ kubectl port-forward --address 0.0.0.0 -n default svc/kube-prometheus-stack-58-alertmanager 9093:9093
Forwarding from 0.0.0.0:9093 -> 9093
```

Detach from screen by `Ctrl+A+D`

Now browse the url: `http://<host-name>:9093` for my case it's `http://192.168.0.193:9093` You should see the screen like the following screenshot.

![image](https://github.com/rabbicse/microservices/blob/master/screenshots/kubernetes/kubernetes-alertmanager.png)


## References
- [Kube Prometheus Stack](https://github.com/prometheus-community/helm-charts/blob/main/charts/kube-prometheus-stack/)
- [Install Prometheus and Grafana on Kubernetes using prometheus-operator](https://computingforgeeks.com/setup-prometheus-and-grafana-on-kubernetes/)
- [Access UI] (https://github.com/prometheus-operator/kube-prometheus/blob/main/docs/access-ui.md)
