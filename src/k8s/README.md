This folder contains k8s manifest files

<details>
  <summary>Ingress</summary>

  [ingress-nginx](https://kubernetes.github.io/ingress-nginx/) is used as Ingress controller, so this will need to be set up for every environment which will run app throught k8s.
</details>

<details>
  <summary>Minikube</summary>

  For running application in k8s locally - [minikube](https://minikube.sigs.k8s.io/docs/) can be used.  With minikube, it is very important to use a vm driver like hyperv. If you do not pass a driver flag to the start command minikube will use the docker driver instead [this will not work with ingress and you won't be able to open application through 'minikube ip'](https://minikube.sigs.k8s.io/docs/drivers/docker/#known-issues). <br />
Useful minikube commands: <br />
minikube start --driver=hyperv
  (To make hyperv the default driver: minikube config set driver hyperv)<br />
minikube ip <br />
minikube docker-env <br />
</details>




