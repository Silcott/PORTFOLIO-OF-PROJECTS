# Project Step 7
### James Silcott
### 16 August 2020
### USE CASE: Help Desk Application
---
### Actors
		User/Customer
		Help Desk Operator/Technician
		Helping Agents
---
### Trigger
		User/Customer creates a new status ticket
---
### Precondition
		User/Customer must login to existing account and/or
		User/Customer must create an account 
		User/Customer must create a ticket with new status
---
### Post-condition
		User/Customer will be notified by Help Desk Operator/Technician changes and response to existing ticket
---
### Normal Flow
		1. The user/customer identifies they have a problem that requires help
		2. The user/customer creates an account 
		3. The user/customer logins to the help desk system
		4. The user/customer creates a new ticket with new status
		5. The help desk operator/technician creates an account
		6. The help desk operator/technician logins to the help desk system
		7. The help desk operator/technician views the open status ticket
		8. The help desk operator/technician changes the status from new to open, pending, resolved, or closed 
		9. The help desk operator/technician identifies the problem and assigns the ticket to the helping agents
		10. The help desk operator/technician completes the ticket
		11. The help desk operator/technician changes the ticket status to closed
		12. The user/customer receives by email and reviews updates on the status
---
### Alternate Flow
#### A. The User/Customer doesn't fill the correct or more information is required 
		1. If the form fields don't have the correct characters it will notify the user/customer to input correct format.
		2. The use case will return to step 4
 
#### B. The Help Desk Operator/Technician requires more information to help solve the problem. 
		1. If the help desk operator/technician requires will change the status from new or open to pending and email the 
		user/customer to update the required info.
		2. The use case will return to step 4
 
#### C. The User/Customer changes the status of an existing ticket to resolved because they either changed their mind or the problem was corrected already
		1. This will trigger a response to the help desk operator/technician and the status will be changed to closed
		2. The use case will return to step 12