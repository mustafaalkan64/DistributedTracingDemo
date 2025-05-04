# DistributedTracingDemo

A demonstration of distributed tracing in a microservices architecture using **OpenTelemetry** and **Jaeger**. This project includes three services: **OrderService**, **PaymentService**, and **InventoryService**, all built with **.NET 9** and orchestrated using **Docker Compose**.

---

## 📌 Table of Contents

- [Overview](#overview)
- [Architecture](#architecture)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Tracing with Jaeger](#tracing-with-jaeger)
- [Contributing](#contributing)
- [License](#license)

---

## 🧩 Overview

This project demonstrates how to implement **distributed tracing** in a microservices environment. By integrating **OpenTelemetry** and **Jaeger**, it provides visibility into the flow of requests across different services—helping to monitor, debug, and optimize service communication.

---

## 🏗️ Architecture

The system consists of the following components:

- **OrderService**  
  Handles order placement and initiates calls to the Payment and Inventory services.

- **PaymentService**  
  Processes payment transactions.

- **InventoryService**  
  Manages and updates inventory stock levels.

- **Jaeger**  
  Collects and visualizes the tracing data from all services.

Each service is instrumented using **OpenTelemetry** to emit trace data that can be visualized in **Jaeger**.

---

## 🛠️ Technologies Used

- [.NET 9](https://dotnet.microsoft.com/)
- [OpenTelemetry](https://opentelemetry.io/)
- [Jaeger](https://www.jaegertracing.io/)
- [Docker](https://www.docker.com/)
- [Docker Compose](https://docs.docker.com/compose/)

---

## 🚀 Getting Started

### Prerequisites

Ensure you have the following installed:

- [Docker](https://www.docker.com/)

### Installation

1. **Clone the repository:**

   ```bash
   git clone https://github.com/mustafaalkan64/DistributedTracingDemo.git
   cd DistributedTracingDemo
