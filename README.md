# MFPE – Policy Administration System ( POD2 ) CSD Training

This application uses 4 microservices for its functioning. We need to run all these 4 microservices
simultaneously in order for the angular application to function properly. 

1) Open Consumer Microservice, perform successful migrations, execute it and keep it running. 
2) Open Quotes Microservice, perform successful migrations, execute it and keep it running. Here, we need to add a 
matrix for the proper functioning of the Policy Microservice.
3) Open Policy Microservice, which uses Quotes Microservice for its proper functioning. Firstly, we need to perform
migrations. Execute it and keep it running. Insure that Quotes microservice is successfully executing. 
4) Open Authorization Microservice. Execute it and keep it running. It generates an authentication token. It is used for
authentication of the Insurance Agent and his/her authorization. 
5) Open Insureity application. It is an angular application. Open terminal. Then, execute the application.
(Command : ng serve -o) 
6) Browse https://localhost:4200

Credentials 
Username : sparrow
Password : sparrow

How To Perform Migration
➢ Open Package Manager Console
➢ Type Add-Migration “<any string>”
➢ Type Update-Database
➢ Migrations need to be performed in all the 4 
microservices.
In Quotes microservice, the matrix 
needs to be added by using the swagger 
interface
