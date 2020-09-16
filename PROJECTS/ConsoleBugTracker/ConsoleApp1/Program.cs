using BugTracker;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Text;
using System.Runtime.InteropServices;

namespace BugTracker
{
    public static class FullScreen
    {
        //this is for the fullscreen mode
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;

        //This will set the console window to full screen
        public static void WideScreenMethod()
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);
        }
    }
    public static class HashPassword
    {
        //Hashing Method
        public static string CalculateSHA256(string str)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] hashValue;
            hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(str));
            //Convert byte array to a string
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hashValue.Length; i++)
            {
                builder.Append(hashValue[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }
    public class ticketBLL //Ticket Business Logic Layer
    {
        public string email { get; set; }
        public string ticket_creator_name { get; set; }
        public string phone { get; set; }
        public string location { get; set; }
        public string issue_category { get; set; }
        public string priority_level { get; set; }
        public string issue_decription { get; set; }
        public string added_date { get; set; }
        public string completed_date { get; set; }
        public string cost { get; set; }
        public string file_name_path { get; set; }
        public int ticketNumber { get; set; }
    }
    public class userBLL //User Business Logic Layer
    {

        public string email { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public string address { get; set; }

    }
    public class Database
    {
        public static Dictionary<string, userBLL> databaseUser = new Dictionary<string, userBLL>();
        public static Dictionary<int, ticketBLL> databaseTicket = new Dictionary<int, ticketBLL>();
    }
    public static class DAL //Data Access Layer
    {
        public static int count = 1;
        public static int ticketNumber = 0;
        public static void InsertUser()
        {
            Console.WriteLine("You selected to Add New User");
            Console.WriteLine("Registration Form:\n");

            Console.Write("Enter new username: ");
            var responseUsername = Console.ReadLine();

            Console.Write("\nEnter your password: ");
            var responsePassword = Console.ReadLine();

            Console.Write("\nEnter your email: ");
            var responseEmail = Console.ReadLine();

            Console.Write("\nEnter your phone number: ");
            var responsePhone = Console.ReadLine();

            Console.Write("\nEnter your address: ");
            var responseAddress = Console.ReadLine();

            Database.databaseUser.Add(responseUsername, new userBLL { password = HashPassword.CalculateSHA256(responsePassword), email = responseEmail, phone = responsePhone, address = responseAddress });

            Console.Write($"You've entered the following:\n " +
                               $"Username: {responseUsername}" +
                               $"\nPassword: {Database.databaseUser[responseUsername].password}" +
                               $"\nEmail: {Database.databaseUser[responseUsername].email}" +
                               $"\nPhone: {Database.databaseUser[responseUsername].phone}" +
                               $"\nAddress: {Database.databaseUser[responseUsername].address}");
            Console.WriteLine($"\n {responseUsername} has been added");
            //Return to the Menu
            UserInterfaceScreen.ManagementMenu.SelectMgtMenu();
        }
        public static void InsertTicket()
        {
            ticketNumber = 0;

            Console.WriteLine("You selected to Add New Ticket");
            Console.WriteLine("Ticket Form:\n");

            Console.Write("Enter Requesters Name: ");
            var responseUsername = Console.ReadLine();

            Console.Write("\nEnter Requesters Email: ");
            var responseEmail = Console.ReadLine();

            Console.Write("\nEnter Requesters Phone Number: ");
            var responsePhone = Console.ReadLine();

            Console.Write("\nEnter Requesters Location: ");
            var responseLocation = Console.ReadLine();

            Console.Write("\nEnter Issue Category: ");
            var responseCat = Console.ReadLine();

            Console.Write("\nEnter Priority Level: ");
            var responsePLevel = Console.ReadLine();

            Console.Write("\nEnter Description of the Issue: ");
            var responseDescription = Console.ReadLine();

            Console.Write("\nEnter Date of Issue: ");
            var responseDateOfIssue = Console.ReadLine();

            Console.Write("\nEnter Completion Date: ");
            var responseDateCompleted = Console.ReadLine();

            Console.Write("\nEnter Costs: ");
            var responseCost = Console.ReadLine();

            ticketNumber = ticketNumber + count;
            Database.databaseTicket.Add(ticketNumber, new ticketBLL
            {
                ticket_creator_name = responseUsername,
                email = responseEmail,
                phone = responsePhone,
                location = responseLocation,
                issue_category = responseCat,
                priority_level = responsePLevel,
                issue_decription = responseDescription,
                added_date = responseDateOfIssue,
                completed_date = responseDateCompleted,
                cost = responseCost
            });
            count += 1;
            Console.Write($"You've entered the following:\n " +
                               $"\nTicket Number: {ticketNumber}" +
                               $"\nRequesters Username: {responseUsername}" +
                               $"\nRequesters Email: {Database.databaseTicket[ticketNumber].email}" +
                               $"\nRequesters Phone: {Database.databaseTicket[ticketNumber].phone}" +
                               $"\nRequesters Location: {Database.databaseTicket[ticketNumber].location}" +
                               $"\nIssue Category: {Database.databaseTicket[ticketNumber].issue_category}" +
                               $"\nIssue Priority Level: {Database.databaseTicket[ticketNumber].priority_level}" +
                               $"\nDescription: {Database.databaseTicket[ticketNumber].issue_decription}" +
                               $"\nIssued Date: {Database.databaseTicket[ticketNumber].added_date}" +
                               $"\nCompletion Date: {Database.databaseTicket[ticketNumber].completed_date}" +
                               $"\nCosts: ${Database.databaseTicket[ticketNumber].cost}.00" +
                               $"\n");
            Console.WriteLine($"\n Ticket: #{ticketNumber} has been added");
            //Return to the Menu
            UserInterfaceScreen.ManagementMenu.SelectMgtMenu();
        }

        public static void UpdateTicket()
        {
            Console.WriteLine("You selected to update a Ticket");
            Console.WriteLine("Ticket Form:\n");

            Console.Write("Enter Ticket Number To Update: ");
            var responseTicketNumber = Convert.ToInt32(Console.ReadLine());

            if (Database.databaseTicket.ContainsKey(responseTicketNumber))
            {
                Console.Write($"Here's the Ticket Info:\n " +
                               $"[1] Requesters Username: {Database.databaseTicket[responseTicketNumber].ticket_creator_name}" +
                               $"\n[2] Requesters Email: {Database.databaseTicket[responseTicketNumber].email}" +
                               $"\n[3] Requesters Phone: {Database.databaseTicket[responseTicketNumber].phone}" +
                               $"\n[4] Requesters Location: {Database.databaseTicket[responseTicketNumber].location}" +
                               $"\n[5] Issue Category: {Database.databaseTicket[responseTicketNumber].issue_category}" +
                               $"\n[6] Issue Priority Level: {Database.databaseTicket[responseTicketNumber].priority_level}" +
                               $"\n[7] Description: {Database.databaseTicket[responseTicketNumber].issue_decription}" +
                               $"\n[8] Issued Date: {Database.databaseTicket[responseTicketNumber].added_date}" +
                               $"\n[9] Completion Date: {Database.databaseTicket[responseTicketNumber].completed_date}" +
                               $"\n[10] Costs: ${Database.databaseTicket[responseTicketNumber].cost}.00" +
                               $"\n");
                Console.WriteLine("Select a number to update:");
                var response = Convert.ToInt32(Console.ReadLine());
                switch (response)
                {
                    case 1:
                        Console.Write("\nEnter New Username: ");
                        var responseNewUsername = Console.ReadLine();
                        Database.databaseTicket[responseTicketNumber].ticket_creator_name = responseNewUsername;
                        Console.WriteLine($"Updated the Username with {responseNewUsername}");
                        break;
                    case 2:
                        Console.Write("\nEnter New Email: ");
                        var responseNewEmail = Console.ReadLine();
                        Database.databaseTicket[responseTicketNumber].email = responseNewEmail;
                        Console.WriteLine($"Updated the Email with {responseNewEmail}");
                        break;
                    case 3:
                        Console.Write("\nEnter New Phone Number: ");
                        var responseNewPhone = Console.ReadLine();
                        Database.databaseTicket[responseTicketNumber].phone = responseNewPhone;
                        Console.WriteLine($"Updated the Phone Number with {responseNewPhone}");
                        break;
                    case 4:
                        Console.Write("\nEnter New Location: ");
                        var responseNewLocation = Console.ReadLine();
                        Database.databaseTicket[responseTicketNumber].location = responseNewLocation;
                        Console.WriteLine($"Updated the Location with {responseNewLocation}");
                        break;
                    case 5:
                        Console.Write("\nEnter New Catergory: ");
                        var responseNewCategory = Console.ReadLine();
                        Database.databaseTicket[responseTicketNumber].issue_category = responseNewCategory;
                        Console.WriteLine($"Updated the Category with {responseNewCategory}");
                        break;
                    case 6:
                        Console.Write("\nEnter New Priority Level: ");
                        var responseNewPLevel = Console.ReadLine();
                        Database.databaseTicket[responseTicketNumber].priority_level = responseNewPLevel;
                        Console.WriteLine($"Updated the Priority Level with {responseNewPLevel}");
                        break;
                    case 7:
                        Console.Write("\nEnter New Description: ");
                        var responseNewDescription = Console.ReadLine();
                        Database.databaseTicket[responseTicketNumber].issue_decription = responseNewDescription;
                        Console.WriteLine($"Updated the Description with {responseNewDescription}");
                        break;
                    case 8:
                        Console.Write("\nEnter New Issued Date: ");
                        var responseNewIssuedDate = Console.ReadLine();
                        Database.databaseTicket[responseTicketNumber].added_date = responseNewIssuedDate;
                        Console.WriteLine($"Updated the Issue Date with {responseNewIssuedDate}");
                        break;
                    case 9:
                        Console.Write("\nEnter New Completion Date: ");
                        var responseNewCompletedDate = Console.ReadLine();
                        Database.databaseTicket[responseTicketNumber].completed_date = responseNewCompletedDate;
                        Console.WriteLine($"Updated the Completed Date with {responseNewCompletedDate}");
                        break;
                    case 10:
                        Console.Write("\nEnter New Costs: ");
                        var responseNewCost = Console.ReadLine();
                        Database.databaseTicket[responseTicketNumber].ticket_creator_name = responseNewCost;
                        Console.WriteLine($"Updated the Costs with ${responseNewCost}.00");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Do you want to make anymore updates?");
                var responseAgain = Console.ReadLine().ToUpper();
                if (responseAgain == "Y")
                {
                    UpdateTicket();
                }
                else
                {
                    UserInterfaceScreen.ManagementMenu.SelectMgtMenu();
                }
            }
            else
            {
                Console.WriteLine($"Sorry, no record of {responseTicketNumber}");
                Console.WriteLine("Wish to try another name? [Y] or [N]");
                var response = Console.ReadLine().ToUpper();
                if (response == "Y")
                {
                    Console.Clear();
                    UpdateTicket();
                }
                else
                {
                    Console.Clear();
                    UserInterfaceScreen.ManagementMenu.SelectMgtMenu();
                }
            }
        }
        public static void UpdateUser()
        {
            Console.WriteLine("You selected to update a User");
            Console.WriteLine("User Form:\n");

            Console.Write("Enter Name To Update: ");
            var responseUsername = Console.ReadLine();

            if (Database.databaseUser.ContainsKey(responseUsername))
            {
                Console.Write($"Here's the User Info:\n " +
                               $"Username: {responseUsername}" +
                               $"\n[1] Password: {Database.databaseUser[responseUsername].password}" +
                               $"\n[2] Email: {Database.databaseUser[responseUsername].email}" +
                               $"\n[3] Phone: {Database.databaseUser[responseUsername].phone}" +
                               $"\n[4] Address: {Database.databaseUser[responseUsername].address}" +
                               $"\n" +
                               $"\n *Note: You Can Not Change the Username, You need to Delete and Add New if Needed\n");
                Console.WriteLine("Select a number to update:");
                var response = Convert.ToInt32(Console.ReadLine());
                switch (response)
                {
                    case 1:
                        Console.Write("\nEnter New Password: ");
                        Console.Write("Typing is not visble");
                        string responseNewPassword = null;
                        while (true)
                        {
                            var key = System.Console.ReadKey(true);
                            if (key.Key == ConsoleKey.Enter)
                            {
                                break;
                            }
                            responseNewPassword += key.KeyChar;
                        }
                        Database.databaseUser[responseUsername].password = HashPassword.CalculateSHA256(responseNewPassword);
                        Console.WriteLine($"Updated the Password with {responseNewPassword}");
                        break;
                    case 2:
                        Console.Write("\nEnter New Email: ");
                        var responseNewEmail = Console.ReadLine();
                        Database.databaseUser[responseUsername].email = responseNewEmail;
                        Console.WriteLine($"Updated the Email with {responseNewEmail}");
                        break;
                    case 3:
                        Console.Write("\nEnter New Phone Number: ");
                        var responseNewPhone = Console.ReadLine();
                        Database.databaseUser[responseUsername].phone = responseNewPhone;
                        Console.WriteLine($"Updated the Phone Number with {responseNewPhone}");
                        break;
                    case 4:
                        Console.Write("\nEnter New Address: ");
                        var responseNewAddress = Console.ReadLine();
                        Database.databaseUser[responseUsername].address = responseNewAddress;
                        Console.WriteLine($"Updated the Address with {responseNewAddress}");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Do you want to make anymore updates?");
                var responseAgain2 = Console.ReadLine().ToUpper();
                if (responseAgain2 == "Y")
                {
                    UpdateUser();
                }
                else
                {
                    UserInterfaceScreen.ManagementMenu.SelectMgtMenu();
                }
            }
            else
            {
                Console.WriteLine($"Sorry, no record of {responseUsername}");
                Console.WriteLine("Wish to try another name? [Y] or [N]");
                var response = Console.ReadLine().ToUpper();
                if (response == "Y")
                {
                    Console.Clear();
                    UpdateUser();
                }
                else
                {
                    Console.Clear();
                    UserInterfaceScreen.ManagementMenu.SelectMgtMenu();
                }
            }
        }
        public static void DeleteTicket()
        {
            Console.WriteLine("You selected to delete a Ticket");

            Console.Write("Enter Ticket Number to Delete: ");
            var reponseTicketNumber = Convert.ToInt32(Console.ReadLine());

            if (Database.databaseTicket.ContainsKey(reponseTicketNumber))
            {
                Database.databaseTicket.Remove(reponseTicketNumber);
            }
            else
            {
                Console.WriteLine($"Sorry, no record of {reponseTicketNumber}");
                Console.WriteLine("Wish to try another name? [Y] or [N]");
                var response = Console.ReadLine().ToUpper();
                if (response == "Y")
                {
                    Console.Clear();
                    DeleteTicket();
                }
                else
                {
                    Console.Clear();
                    UserInterfaceScreen.ManagementMenu.SelectMgtMenu();
                }
            }
            Console.WriteLine("The Ticket has been removed");
            Console.WriteLine("Do you want to make anymore deletes?");
            var responseAgain2 = Console.ReadLine().ToUpper();
            if (responseAgain2 == "Y")
            {
                DeleteTicket();
            }
            else
            {
                UserInterfaceScreen.ManagementMenu.SelectMgtMenu();
            }
        }
        public static void DeleteUser()
        {
            Console.WriteLine("You selected to delete a User");

            Console.Write("Enter Name To Delete: ");
            var responseUsername = Console.ReadLine();

            if (Database.databaseUser.ContainsKey(responseUsername))
            {
                Database.databaseUser.Remove(responseUsername);
            }
            else
            {
                Console.WriteLine($"Sorry, no record of {responseUsername}");
                Console.WriteLine("Wish to try another name? [Y] or [N]");
                var response = Console.ReadLine().ToUpper();
                if (response == "Y")
                {
                    Console.Clear();
                    DeleteUser();
                }
                else
                {
                    Console.Clear();
                    UserInterfaceScreen.ManagementMenu.SelectMgtMenu();
                }
            }
            Console.WriteLine("The Username has been removed");
            Console.WriteLine("Do you want to make anymore deletes?");
            var responseAgain2 = Console.ReadLine().ToUpper();
            if (responseAgain2 == "Y")
            {
                DeleteUser();
            }
            else
            {
                UserInterfaceScreen.ManagementMenu.SelectMgtMenu();
            }
        }
        public static void SearchTicket()
        {
            Console.WriteLine("You have Selected Search");
            Console.WriteLine("[1] View All Current Tickets");
            Console.WriteLine("[2] Search by Ticket Number");
            var response1 = Console.ReadLine();
            if (response1 == "1")
            {
                Console.WriteLine("\n\nPrinting All Tickets:");
                foreach (KeyValuePair<int, ticketBLL> user in Database.databaseTicket)
                {
                    int name = user.Key;
                    Console.WriteLine($"Ticket#: {name}\n");
                    Console.Write($"Here's the Ticket Info:" +
                                  $"\nRequesters Username: {Database.databaseTicket[name].ticket_creator_name}" +
                                  $"\nRequesters Email: {Database.databaseTicket[name].email}" +
                                  $"\nRequesters Phone: {Database.databaseTicket[name].phone}" +
                                  $"\nRequesters Location: {Database.databaseTicket[name].location}" +
                                  $"\nIssue Category: {Database.databaseTicket[name].issue_category}" +
                                  $"\nIssue Priority Level: {Database.databaseTicket[name].priority_level}" +
                                  $"\nDescription: {Database.databaseTicket[name].issue_decription}" +
                                  $"\nIssued Date: {Database.databaseTicket[name].added_date}" +
                                  $"\nCompletion Date: {Database.databaseTicket[name].completed_date}" +
                                  $"\nCosts: ${Database.databaseTicket[name].cost}" +
                                  $"\n");
                }
                Console.WriteLine("Do you want to make anymore Searches?");
                var responseAgain2 = Console.ReadLine().ToUpper();
                if (responseAgain2 == "Y")
                {
                    SearchTicket();
                }
                else
                {
                    UserInterfaceScreen.ManagementMenu.SelectMgtMenu();
                }
            }
            else if (response1 == "2")
            {
                Console.Write("Enter Ticket Number To Search: ");
                var responseTicketNumber = Convert.ToInt32(Console.ReadLine());

                if (Database.databaseTicket.ContainsKey(responseTicketNumber))
                {
                    Console.Write($"Here's the Ticket Info:\n " +
                                   $"Requesters Username: {Database.databaseTicket[responseTicketNumber].ticket_creator_name}" +
                                   $"\nRequesters Email: {Database.databaseTicket[responseTicketNumber].email}" +
                                   $"\nRequesters Phone: {Database.databaseTicket[responseTicketNumber].phone}" +
                                   $"\nRequesters Location: {Database.databaseTicket[responseTicketNumber].location}" +
                                   $"\nIssue Category: {Database.databaseTicket[responseTicketNumber].issue_category}" +
                                   $"\nIssue Priority Level: {Database.databaseTicket[responseTicketNumber].priority_level}" +
                                   $"\nDescription: {Database.databaseTicket[responseTicketNumber].issue_decription}" +
                                   $"\nIssued Date: {Database.databaseTicket[responseTicketNumber].added_date}" +
                                   $"\nCompletion Date: {Database.databaseTicket[responseTicketNumber].completed_date}" +
                                   $"\nCosts: ${Database.databaseTicket[responseTicketNumber].cost}" +
                                   $"\n");
                }
                else
                {
                    Console.WriteLine($"Sorry, no record of {responseTicketNumber}");
                    Console.WriteLine("Wish to try another name? [Y] or [N]");
                    var response = Console.ReadLine().ToUpper();
                    if (response == "Y")
                    {
                        Console.Clear();
                        SearchTicket();
                    }
                    else
                    {
                        Console.Clear();
                        UserInterfaceScreen.ManagementMenu.SelectMgtMenu();
                    }
                }
                Console.WriteLine("Do you want to make anymore Searches?");
                var responseAgain2 = Console.ReadLine().ToUpper();
                if (responseAgain2 == "Y")
                {
                    SearchTicket();
                }
                else
                {
                    UserInterfaceScreen.ManagementMenu.SelectMgtMenu();
                }
            }
            else
            {
                Console.WriteLine("That was not a choice. Try Again");
                SearchTicket();
            }
        }
        public static void SearchUser()
        {
            Console.WriteLine("You have Selected Search");
            Console.WriteLine("[1] View All Current Users");
            Console.WriteLine("[2] Search by User Name");
            var response1 = Console.ReadLine();
            if (response1 == "1")
            {
                Console.WriteLine("\n\nPrinting All Users:");
                foreach (KeyValuePair<string, userBLL> user in Database.databaseUser)
                {
                    string name = user.Key;
                    Console.WriteLine($"User: {name}\n");
                    Console.Write($"Here's the User Info:" +
                                  $"\nPassword: {Database.databaseUser[name].password}" +
                                  $"\nEmail: {Database.databaseUser[name].email}" +
                                  $"\nPhone: {Database.databaseUser[name].phone}" +
                                  $"\nAddress: {Database.databaseUser[name].address}" +
                                  $"\n");
                }
                Console.WriteLine("Do you want to make anymore Searches? [Y] or [N]");
                var responseAgain2 = Console.ReadLine().ToUpper();
                if (responseAgain2 == "Y")
                {
                    SearchUser();
                }
                else
                {
                    UserInterfaceScreen.ManagementMenu.SelectMgtMenu();
                }
            }
            else if (response1 == "2")
            {


                Console.Write("Enter Name To Search: ");
                var responseUsername = Console.ReadLine();

                if (Database.databaseUser.ContainsKey(responseUsername))
                {
                    Console.Write($"Here's the User Info:\n " +
                                   $"Username: {responseUsername}" +
                                   $"\nPassword: {Database.databaseUser[responseUsername].password}" +
                                   $"\nEmail: {Database.databaseUser[responseUsername].email}" +
                                   $"\nPhone: {Database.databaseUser[responseUsername].phone}" +
                                   $"\nAddress: {Database.databaseUser[responseUsername].address}\n");
                }
                else
                {
                    Console.WriteLine($"Sorry, no record of {responseUsername}");
                    Console.WriteLine("Wish to try another name? [Y] or [N]");
                    var response = Console.ReadLine().ToUpper();
                    if (response == "Y")
                    {
                        Console.Clear();
                        SearchUser();
                    }
                    else
                    {
                        Console.Clear();
                        UserInterfaceScreen.ManagementMenu.SelectMgtMenu();
                    }
                }
                Console.WriteLine("Do you want to make anymore Searches? [Y] or [N]");
                var responseAgain2 = Console.ReadLine().ToUpper();
                if (responseAgain2 == "Y")
                {
                    SearchUser();
                }
                else
                {
                    UserInterfaceScreen.ManagementMenu.SelectMgtMenu();
                }
            }
        }
    }
}
public static class UserInterfaceScreen
{
    public static void UI()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("                     Welcome to the Bug Tracker Program: Created By James Silcott");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("---------------------------------------------------------------------------------------------------------");
        Console.Write(@"
                         ▄▄▄▄▄▄▄▄▄▄   ▄         ▄  ▄▄▄▄▄▄▄▄▄▄▄ 
                        ▐░░░░░░░░░░▌ ▐░▌       ▐░▌▐░░░░░░░░░░░▌
                        ▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌▐░█▀▀▀▀▀▀▀▀▀ 
                        ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌          
                        ▐░█▄▄▄▄▄▄▄█░▌▐░▌       ▐░▌▐░▌ ▄▄▄▄▄▄▄▄ 
                        ▐░░░░░░░░░░▌ ▐░▌       ▐░▌▐░▌▐░░░░░░░░▌
                        ▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌▐░▌ ▀▀▀▀▀▀█░▌
                        ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌
                        ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌
                        ▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌
                         ▀▀▀▀▀▀▀▀▀▀   ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀ 
");
        Console.Write(@"
                                                                                     
 ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄    ▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄ 
▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌
 ▀▀▀▀█░█▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░▌ ▐░▌ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌
     ▐░▌     ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌          ▐░▌▐░▌  ▐░▌          ▐░▌       ▐░▌
     ▐░▌     ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌▐░▌          ▐░▌░▌   ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄█░▌
     ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌          ▐░░▌    ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌
     ▐░▌     ▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░▌          ▐░▌░▌   ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀█░█▀▀ 
     ▐░▌     ▐░▌     ▐░▌  ▐░▌       ▐░▌▐░▌          ▐░▌▐░▌  ▐░▌          ▐░▌     ▐░▌  
     ▐░▌     ▐░▌      ▐░▌ ▐░▌       ▐░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░▌ ▐░▌ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌      ▐░▌ 
     ▐░▌     ▐░▌       ▐░▌▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌▐░░░░░░░░░░░▌▐░▌       ▐░▌
      ▀       ▀         ▀  ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀    ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀ 
                                                                                      
");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(@"");
        Console.WriteLine(@"");
        Console.WriteLine(@"                                           _ _       \ \");
        Console.WriteLine(@"                                .-"""""" -. / \_ > /\    |/");
        Console.WriteLine(@"                               /         \.'`  `',.--//");
        Console.WriteLine(@"                             -(           I      I  @@\");
        Console.WriteLine(@"                               \         /'.____.'\___|");
        Console.WriteLine(@"                                '-.....-' __/ | \   (`)");
        Console.WriteLine(@"                                         /   /  /");
        Console.WriteLine(@"                                             \  \");
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("---------------------------------------------------------------------------------------------------------");

        Console.WriteLine("Please Log In");
        Console.WriteLine("What is your username: ");
        var responseUsername = Console.ReadLine();

        if (!Database.databaseUser.ContainsKey(responseUsername))
        {
            Console.WriteLine("You are not registered, would you like to register? [Y] or [N]");
            Console.WriteLine("");
            var responseChoice = Console.ReadLine().ToUpper();
            if (responseChoice == "Y")
            {
                Console.Clear();
                Console.WriteLine("Registration Form:\n");

                Console.Write("Enter your password: ");
                Console.Write("Typing is not visble");
                string responsePassword = null;
                while (true)
                {
                    var key = System.Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                    responsePassword += key.KeyChar;
                }

                Console.Write("\nEnter your email: ");
                var responseEmail = Console.ReadLine();

                Console.Write("\nEnter your phone number: ");
                var responsePhone = Console.ReadLine();

                Console.Write("\nEnter your address: ");
                var responseAddress = Console.ReadLine();

                Database.databaseUser.Add(responseUsername, new userBLL { password = HashPassword.CalculateSHA256(responsePassword), email = responseEmail, phone = responsePhone, address = responseAddress });
                Console.WriteLine($"You've entered the following:\n " +
                    $"Username: {responseUsername}" +
                    $"\nPassword: {Database.databaseUser[responseUsername].password}" +
                    $"\nEmail: {Database.databaseUser[responseUsername].email}" +
                    $"\nPhone: {Database.databaseUser[responseUsername].phone}" +
                    $"\nAddress: {Database.databaseUser[responseUsername].address}");
                Console.WriteLine("Thank you for registering\n\n");
                UI();
            }
            else
            {
                Console.WriteLine("Would you like to log in with a different name?");
                var reply = Console.ReadLine().ToUpper();
                if (reply == "Y")
                {
                    UI();
                }
                else if (reply == "N")
                {
                    Console.WriteLine("Have A Great Day!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Something strange happened, Try Again");
                    UI();
                }
            }
            Console.WriteLine("What is your password: ");
            Console.Write("Typing is not visble");
            string responsePassword1 = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
                responsePassword1 += key.KeyChar;
            }
            if (Database.databaseUser[responseUsername].password == responsePassword1)
            {
                Console.WriteLine($"Welcome {responseUsername}");
            }
            ManagementMenu.SelectMgtMenu();
        }
        else
        {
            Console.WriteLine("What is your password: ");
            Console.Write("Typing is not visble\n");
            string responsePassword1 = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
                responsePassword1 += key.KeyChar;
            }
            if (Database.databaseUser[responseUsername].password == responsePassword1)
            {
                Console.WriteLine($"Welcome Back {responseUsername}");
            }
            else if (Database.databaseUser[responseUsername].password != HashPassword.CalculateSHA256(responsePassword1))
            {
                Console.Clear();
                UI();
                Console.WriteLine("Sorry that password is not correct, try again");
            }
            ManagementMenu.SelectMgtMenu();
        }
    }
    public static class ManagementMenu
    {
        public static void SelectMgtMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Choose Management Menu");
            Console.WriteLine("[1] Ticket Management");
            Console.WriteLine("[2] Account Management");

            var responseChoice = Console.ReadLine().ToUpper();

            //Ticket Management
            if (responseChoice == "1")
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Ticket Management");
                Console.WriteLine("[1] Create New Ticket");
                Console.WriteLine("[2] Update Ticket");
                Console.WriteLine("[3] Delete Ticket");
                Console.WriteLine("[4] Search for Ticket");
                var responseChoiceTicketMgt = Console.ReadLine().ToUpper();
                if (responseChoiceTicketMgt == "1")
                {
                    DAL.InsertTicket();
                }
                else if (responseChoiceTicketMgt == "2")
                {
                    DAL.UpdateTicket();
                }
                else if (responseChoiceTicketMgt == "3")
                {
                    DAL.DeleteTicket();
                }
                else if (responseChoiceTicketMgt == "4")
                {
                    DAL.SearchTicket();
                }
                else
                {
                    Console.WriteLine("Something strange happened, Try Again");
                    SelectMgtMenu();
                }
            }
            //Account Management
            else if (responseChoice == "2")
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Account Management");
                Console.WriteLine("[1] Add New User");
                Console.WriteLine("[2] Update User");
                Console.WriteLine("[3] Delete User");
                Console.WriteLine("[4] Search for User");
                var responseChoiceAcctMgt = Console.ReadLine().ToUpper();
                if (responseChoiceAcctMgt == "1")
                {
                    DAL.InsertUser();
                }
                else if (responseChoiceAcctMgt == "2")
                {
                    DAL.UpdateUser();
                }
                else if (responseChoiceAcctMgt == "3")
                {
                    DAL.DeleteUser();
                }
                else if (responseChoiceAcctMgt == "4")
                {
                    DAL.SearchUser();
                }
                else
                {
                    Console.WriteLine("Something strange happened, Try Again");
                    SelectMgtMenu();
                }
            }
            else
            {
                Console.WriteLine("Something strange happened, Try Again");
                SelectMgtMenu();
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {

        UserInterfaceScreen.UI();
    }
}