1. Open Application from Visual studio 2019 or later.
2. Set StorePriceMonitor.API project as a Startup project. 
3. To Execute Migrations, Specially this project used Entity framework, MSSQL server and Code first architecture. All migration files are created but need to create model through that.
	Change the Application DB connection string on appsettings.Development.json file
	Open Package Manager Console
	Set Startup Project as StorePriceMonitor.API and Package Manager console Default Package as a StorePriceMonitor.Infastructure Project
	Run this command: update-database
	
4. After completed all the steps, Run Application
5. Swagger Documentation will be start with the API's
6. Take API's URL's and update relevant locations on Front end applications as well. 