# 📌 Dapr Microservices Project

## 🚀 Introduction
This project uses **Dapr (Distributed Application Runtime)** to build a scalable and event-driven microservices architecture. Dapr simplifies service-to-service communication, state management, pub/sub messaging, and external bindings.

## 📦 Prerequisites
Before running this project, ensure you have the following installed:
- [Docker](https://www.docker.com/get-started)
- [Dapr CLI](https://docs.dapr.io/getting-started/install-dapr-cli/)
- [Dapr Runtime](https://docs.dapr.io/getting-started/install-dapr-selfhost/)
- [Kubernetes (Optional)](https://kubernetes.io/docs/setup/)

## 📂 Project Structure
```
📦 my-dapr-project
├── 📁 services
│   ├── 📁 service-a (Example Microservice)
│   ├── 📁 service-b (Example Microservice)
├── 📁 components (Dapr Configurations)
│   ├── statestore.yaml
│   ├── pubsub.yaml
├── 📄 docker-compose.yaml
└── 📄 README.md
```

## 🛠️ Setup & Run
### **1️⃣ Initialize Dapr**
To set up Dapr locally:
```sh
dapr init
```

### **2️⃣ Run Services with Dapr**
To run a microservice (e.g., `service-a`) with Dapr:
```sh
dapr run --app-id service-a --app-port 5001 --dapr-http-port 3500 -- python app.py
```

### **3️⃣ Using Dapr Service Invocation**
To invoke `service-a` from another service:
```sh
curl -X POST http://localhost:3500/v1.0/invoke/service-a/method/your-endpoint
```

### **4️⃣ Publish & Subscribe (Pub/Sub)**
To publish an event to a topic:
```sh
curl -X POST http://localhost:3500/v1.0/publish/mytopic -H "Content-Type: application/json" -d '{"message": "Hello from Dapr!"}'
```

### **5️⃣ Viewing Logs**
To see running Dapr services:
```sh
dapr list
```

To stop all running Dapr services:
```sh
dapr stop --all
```

## 📝 Configuration Files (Components)
Dapr components are defined in the `components/` folder.
### Example: `statestore.yaml`
```yaml
apiVersion: dapr.io/v1alpha1
kind: Component
metadata:
  name: statestore
spec:
  type: state.redis
  version: v1
  metadata:
    - name: redisHost
      value: "localhost:6379"
    - name: redisPassword
      value: ""
```

## 📌 Deployment (Kubernetes)
To deploy Dapr-enabled services on Kubernetes:
```sh
dapr init --kubernetes
kubectl apply -f deployment.yaml
```

## 📖 Resources
- [Dapr Documentation](https://docs.dapr.io/)
- [Dapr GitHub](https://github.com/dapr/dapr)

---
🎯 **Now you're ready to build event-driven, distributed microservices with Dapr!** 🚀

