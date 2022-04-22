# MFPE – Policy Administration System ( POD2 ) CSD Training

This application uses 4 microservices for its functioning. We need to run all these 4 microservices
simultaneously in order for the angular application to function properly. 

![11](https://user-images.githubusercontent.com/100787996/164678138-f2b4ccd2-04ad-44d9-9c89-1cab8ae12279.JPG)

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
![12](https://user-images.githubusercontent.com/100787996/164678183-94068fd7-4ac7-4fd0-a2cb-e66775789ece.JPG)
![13](https://user-images.githubusercontent.com/100787996/164678192-17a5a6bb-5a6d-4c17-9a18-acaa2be9912f.JPG)
![14](https://user-images.githubusercontent.com/100787996/164678209-5e2b76a9-3ab8-4990-ad9e-35f66954fa32.JPG)
![15](https://user-images.githubusercontent.com/100787996/164678226-7041bb85-e70d-41d3-be00-a6a9d422c77e.JPG)
![16](https://user-images.githubusercontent.com/100787996/164678248-eb591167-c9b8-4d6d-a786-81fd7e3a1136.JPG)
![17](https://user-images.githubusercontent.com/100787996/164678265-e96d7567-bba7-478a-b6ed-d53d9cf389e3.JPG)
![18](https://user-images.githubusercontent.com/100787996/164678272-1c6a9077-d5fc-46b6-b078-eca54dbe605a.JPG)
