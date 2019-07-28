#  masstransit-rabbitmq-example 
Simple application (.NET Core 2.2) to demonstrate the use of [MassTransit](http://masstransit-project.com/MassTransit) messaging framework with [RabbitMQ](https://www.rabbitmq.com/) message broker.
 
### Setup RabbitMQ
1. **Install Erlang** using the [installer](http://www.erlang.org/download.html)
 2. **Install RabbitMQ** using the [installer](http://www.rabbitmq.com/download.html)

### Setup visual studio solution
1. Set solution startup projects to be `CustomersApi` and `EmailsApi`
 
###  See it in action  
Make a `POST` request (with Postman or another tool) to: `http://localhost:5000/customers/register`
with the below body:
```json
{
	"email": "test@email.com"
}
```
and see how a `CustomerRegistedEvent` is published from `CustomersApi` and consumed by `EmailsApi`.