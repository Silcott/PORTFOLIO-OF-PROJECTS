# SQL Database Scripting
[Click HERE to see my Code for this script!](https://github.com/Silcott/ISTA_Project/blob/master/myProject/Project_Track!T/TrackIt/Track!TManagement%20System%20(working)/DAL/userDAL.cs)

<img align="Center" height="400px" width="600px" src="https://raw.githubusercontent.com/Silcott/ISTA_Project/master/myProject/Project_Track!T/Pictures/Cover.svg" alt="html" style="vertical-align:top; margin:4px"> 

# Ticket Recording Application – "Trackin!T".

<img align="Center" height="275px" width="600px" src="https://raw.githubusercontent.com/Silcott/ISTA_Project/master/myProject/Project_Track!T/Pictures/ManageUsersDash-stroke-and-fill.svg" alt="html" style="vertical-align:top; margin:4px"> 
<br> Picture of the Manage User Dashboard

##  SQL Script
#### This is the code I wrote from the application to query results from SQL:
##### First I created a class called userDAL follwing a tutorial online from this: [LINK](https://www.codeproject.com/Articles/679185/Understanding-Three-Layer-Architecture-and-its)
<img align="Center" height="480px" width="600px" src="https://raw.githubusercontent.com/Silcott/ISTA_Project/master/myProject/Project_Track!T/Pictures/Slide_Decks/DFD_of_Three_Layer-stroke-and-fill.svg" alt="html" style="vertical-align:top; margin:4px"> 

##### I used buttons and created methods (functions) named SELECT, INSERT, UPDATE, and DELETE, then coded the following:
### SELECT
-                //Write SQL Query to Get Data from Database
                String sql = "SELECT * FROM tbl_users";
### INSERT
- 				//Create a String Variable to Store the INSERT Query
                String sql = "INSERT INTO tbl_users(username, email, password, full_name, phone, address, added_date, image_name) " +
                    "VALUES " +
                    "(@username, @email, @password, @full_name, @phone, @address, @added_date, @image_name)";

                //Create a SQL Command to pass the value in our Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create the Parameter to pass get the value from UI and pass it on SQL Query above
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@phone", u.phone);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image_name", u.image_name);
### UPDATE - Pretty much the same as INSERT except going to update, set and use where to define the location of the query
- 				//Create a string variable to hold the sql query
                string sql = "UPDATE tbl_users SET username=@username, email=@email, password=@password, full_name=@full_name, phone=@phone, " +
                    "address=@address, added_date=@added_date, image_name=@image_name WHERE user_id=@user_id";

                //Create Sql Command to execute query and pass the values to sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Now pass the values to SQL Query
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@phone", u.phone);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image_name", u.image_name);
                cmd.Parameters.AddWithValue("@user_id", u.user_id);
### DELETE
- 				//Create a string variable to hold the sql query to delet data
                String sql = "Delete FROM tbl_users WHERE user_id=user_id";
				
### Then, I added the tables into Microsoft SQL Server
<img align="Center" height="480px" width="600px" src="https://raw.githubusercontent.com/Silcott/ISTA_Project/master/myProject/Project_Track!T/Pictures/SQL_Server-stroke-and-fill.svg" alt="html" style="vertical-align:top; margin:4px"> 

### I used two tables one named tbl_users, which is for the ticket managers/admin and the other named tbl_requesters, which are customers or help desk employees that input the tickets

### USERS TABLE 
- tbl_users
<img align="Center" height="480px" width="600px" src="https://raw.githubusercontent.com/Silcott/ISTA_Project/master/myProject/Project_Track!T/Pictures/tbl_users-stroke-and-fill.svg" alt="html" style="vertical-align:top; margin:4px"> 


### REQUESTER TABLE
- tbl_requesters
<img align="Center" height="480px" width="600px" src="https://raw.githubusercontent.com/Silcott/ISTA_Project/master/myProject/Project_Track!T/Pictures/tbl_requestors-stroke-and-fill.svg" alt="html" style="vertical-align:top; margin:4px"> 

