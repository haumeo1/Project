//Benjamin To
//501225316
import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;
import java.util.StringTokenizer;

// Simulation of a Simple Command-line based Uber App 

// This system supports "ride sharing" service and a delivery service

public class TMUberUI
{
  public static void main(String[] args)
  {
    // Create the System Manager - the main system code is in here 

    TMUberSystemManager tmuber = new TMUberSystemManager();
    
    Scanner scanner = new Scanner(System.in);
    System.out.print(">");

    // Process keyboard actions
    while (scanner.hasNextLine())
    {
      String action = scanner.nextLine();

      if (action == null || action.equals("")) 
      {
        System.out.print("\n>");
        continue;
      }
      // Quit the App
      else if (action.equalsIgnoreCase("Q") || action.equalsIgnoreCase("QUIT"))
        return;
      // Print all the registered drivers
      else if (action.equalsIgnoreCase("DRIVERS"))  // List all drivers
      {
        tmuber.listAllDrivers(); 
      }
      // Print all the registered users
      else if (action.equalsIgnoreCase("USERS"))  // List all users
      {
        tmuber.listAllUsers(); 
      }
      // Print all current ride requests or delivery requests
      else if (action.equalsIgnoreCase("REQUESTS"))  // List all requests
      {
        tmuber.listAllServiceRequests(); 
      }
      // Register a new driver
      else if (action.equalsIgnoreCase("REGDRIVER")) 
      {
        String name = "";
        System.out.print("Name: ");
        if (scanner.hasNextLine())
        {
          name = scanner.nextLine();
        }
        String carModel = "";
        System.out.print("Car Model: ");
        if (scanner.hasNextLine())
        {
          carModel = scanner.nextLine();
        }
        
        String license = "";
        System.out.print("Car License: ");
        if (scanner.hasNextLine())
        {
          license = scanner.nextLine();
        }
        //create a question to the new driver whether they want to become a XLdriver
        // String XLDriver = "";
        // System.out.print("Xldriver (y/n): ");
        // if(scanner.hasNextLine()){
        //   XLDriver = scanner.nextLine();

        // }
        // if(XLDriver.equalsIgnoreCase("n") || XLDriver.equalsIgnoreCase("no")){
        if (!tmuber.registerNewDriver(name, carModel, license))
          System.out.println(tmuber.getErrorMessage());
        
        else{
          System.out.printf("Driver: %-15s Car Model: %-15s License Plate: %-10s", name, carModel, license);
        }
        // else if (XLDriver.equalsIgnoreCase("y") || XLDriver.equalsIgnoreCase("yes")){
        //   //create a query for seats: this option is only for XlDriver
        // int seat = 3;
        // System.out.print("Seat: ");
        // if(scanner.hasNextLine()){
        //   seat = scanner.nextInt();
        //   scanner.nextLine();
        // }
        // if (!tmuber.registerNewXLDriver(name, carModel, license, seat))
        //   System.out.println(tmuber.getErrorMessage());
        
        // else
        //   System.out.printf("Driver: %-15s Car Model: %-15s License Plate: %-10s Seat: %-1d \tType: Xldriver", name, carModel,license,seat);
        // }
        

        
        
      }
      // Register a xl driver
      else if (action.equalsIgnoreCase("REGXLDRIVER")){
        String name = "";
        System.out.print("Name: ");
        if (scanner.hasNextLine())
        {
          name = scanner.nextLine();
        }
        String carModel = "";
        System.out.print("Car Model: ");
        if (scanner.hasNextLine())
        {
          carModel = scanner.nextLine();
        }
        
        String license = "";
        System.out.print("Car License: ");
        if (scanner.hasNextLine())
        {
          license = scanner.nextLine();
        }
        // get the seat for the car
        int seat = 3;
        System.out.print("Seat: ");
        if(scanner.hasNextLine()){
          seat = scanner.nextInt();
          scanner.nextLine();
        }
        if (!tmuber.registerNewXLDriver(name, carModel, license, seat))
          System.out.println(tmuber.getErrorMessage());
        
        else{
          System.out.printf("Driver: %-15s Car Model: %-15s License Plate: %-10s Seat: %-1d \tType: Xldriver", name, carModel,license,seat);
        }

      }
      // Register a new user
      else if (action.equalsIgnoreCase("REGUSER")) 
      {
        String name = "";
        System.out.print("Name: ");
        if (scanner.hasNextLine())
        {
          name = scanner.nextLine();
        }
        String address = "";
        System.out.print("Address: ");
        if (scanner.hasNextLine())
        {
          address = scanner.nextLine();
        }
        double wallet = 0.0;
        System.out.print("Wallet: ");
        if (scanner.hasNextDouble())
        {
          wallet = scanner.nextDouble();
          scanner.nextLine(); // consume nl!! Only needed when mixing strings and int/double
        }
        if (!tmuber.registerNewUser(name, address, wallet))
          System.out.println(tmuber.getErrorMessage());  
        else
          System.out.printf("User: %-15s Address: %-15s Wallet: %2.2f", name, address, wallet);
      }
      
      else if (action.equalsIgnoreCase("REQRIDE")) 
      {
        // Get the following information from the user (on separate lines)
        // Then use the TMUberSystemManager requestRide() method properly to make a ride request
        // "User Account Id: "      (string)
        // "From Address: "         (string)
        // "To Address: "           (string)
        String userID = "";
        System.out.print("User Account Id: ");
        if (scanner.hasNextLine())
        {
          userID= scanner.nextLine();
        }
        String fromAddress = "";
        System.out.print("From Address: ");
        if (scanner.hasNextLine())
        {
          fromAddress = scanner.nextLine();
        }
        String toAddress = "";
        System.out.print("To Address: ");
        if (scanner.hasNextLine())
        {
          toAddress = scanner.nextLine();
        }
        if (!tmuber.requestRide(userID,fromAddress,toAddress))
          System.out.println(tmuber.getErrorMessage());  
        else
          
          System.out.printf("RIDE for: %-15s From: %-15s To: %-15s", tmuber.getUser(userID), fromAddress, toAddress);
      }
      // New request for XLRide
      else if(action.equalsIgnoreCase("REQXLRIDE")){
        String userID = "";
        System.out.print("User Account Id: ");
        if (scanner.hasNextLine())
        {
          userID= scanner.nextLine();
        }
        String fromAddress = "";
        System.out.print("From Address: ");
        if (scanner.hasNextLine())
        {
          fromAddress = scanner.nextLine();
        }
        String toAddress = "";
        System.out.print("To Address: ");
        if (scanner.hasNextLine())
        {
          toAddress = scanner.nextLine();
        }
        // ask how many customers will be on the ride
        int Passenger = 0;
        System.out.print("Number of customers: ");
        if(scanner.hasNextLine()){
          Passenger = scanner.nextInt();
          scanner.nextLine();
        }
        // if there is only one customer one customer then they will be automaticlly match with a normal driver
        // However, if there are not any not any normal driver available, they will be asked whether they want to take a XLDriver instead
        //check number of customer must be a positive number
        if(Passenger<=0){
          System.out.println("Invalid passenger numbers");
        }
      // // if the number of customers is smaller than 4, they will be math with a XLdriver that have 3 seats
      //   else if(Passenger<4){
      //     if(!(tmuber.requestXlRide(userID, fromAddress, toAddress, Passenger))){
      //       System.out.println(tmuber.getErrorMessage());
      //     }
      //     else{
      //       System.out.printf("XL Ride for: %-15s From: %-15s To: %-15s", tmuber.getUser(userID), fromAddress, toAddress);
      //     }
      //   }
        // if the number of customer between 4 and 6, they will be match to a specific Xldriver that has more than 3 seats
        else if(Passenger<7){
          if(!(tmuber.requestXlRide(userID, fromAddress, toAddress, Passenger))){
            System.out.println(tmuber.getErrorMessage());
          }
          else{
            System.out.printf("XL Ride for: %-15s From: %-15s To: %-15s", tmuber.getUser(userID), fromAddress, toAddress);
          }
        }
        //valid number of customer can only be between 1 and 7 people
        else{
          System.out.println("Invalid number of passengers");
        }
      }
      // Request a food delivery
      else if (action.equalsIgnoreCase("REQDLVY")) 
      {
        // Get the following information from the user (on separate lines)
        // Then use the TMUberSystemManager requestDelivery() method properly to make a ride request
        // "User Account Id: "      (string)
        // "From Address: "         (string)
        // "To Address: "           (string)
        // "Restaurant: "           (string)
        // "Food Order #: "         (string)
        String userID = "";
        System.out.print("User Account Id: ");
        if (scanner.hasNextLine())
        {
          userID= scanner.nextLine();
        }
        String fromAddress = "";
        System.out.print("From Address: ");
        if (scanner.hasNextLine())
        {
          fromAddress = scanner.nextLine();
        }
        String toAddress = "";
        System.out.print("To Address: ");
        if (scanner.hasNextLine())
        {
          toAddress = scanner.nextLine();
        }
        String restaurant = "";
        System.out.print("Restaurant: ");
        if(scanner.hasNextLine()){
          restaurant = scanner.nextLine();
        }
        String FoodOrder = "";
        System.out.print("Food Order #: ");
        if(scanner.hasNextLine()){
          FoodOrder = scanner.nextLine();
        }
        if (!tmuber.requestDelivery(userID,fromAddress,toAddress,restaurant,FoodOrder))
          System.out.println(tmuber.getErrorMessage());  
        else
          System.out.printf("DELIVERY for: %-15s From: %-15s To: %-15s", tmuber.getUser(userID), fromAddress, toAddress);
       
      }
      // Sort users by name
      else if (action.equalsIgnoreCase("SORTBYNAME")) 
      {
        tmuber.sortByUserName();
      }
      // Sort users by number of ride they have had
      else if (action.equalsIgnoreCase("SORTBYWALLET")) 
      {
        tmuber.sortByWallet();
      }
      // Sort current service requests (ride or delivery) by distance
      else if (action.equalsIgnoreCase("SORTBYDIST")) 
      {
        tmuber.sortByDistance();
      }
      // Cancel a current service (ride or delivery) request
      else if (action.equalsIgnoreCase("CANCELREQ")) 
      {
        int request = -1;
        System.out.print("Request #: ");
        if (scanner.hasNextInt())
        {
          request = scanner.nextInt();
          scanner.nextLine(); // consume nl character
        }
        if (!tmuber.cancelServiceRequest(request))
          System.out.println(tmuber.getErrorMessage());  
        else
          System.out.println("Service request #" + request + " cancelled");
      }
      // Drop-off the user or the food delivery to the destination address
      else if (action.equalsIgnoreCase("DROPOFF")) 
      {
        int request = -1;
        System.out.print("Request #: ");
        if (scanner.hasNextInt())
        {
          request = scanner.nextInt();
          scanner.nextLine(); // consume nl
        }
        if (!tmuber.dropOff(request))
          System.out.println(tmuber.getErrorMessage());  
        else
          System.out.println("Successful Drop Off - Service request #" + request + " complete");
      }
      // Get the Current Total Revenues
      else if (action.equalsIgnoreCase("REVENUES")) 
      {
        System.out.printf("Total Revenue: %.2f",tmuber.totalRevenue);
      }
      // Unit Test of Valid City Address 
      else if (action.equalsIgnoreCase("ADDR")) 
      {
        String address = "";
        System.out.print("Address: ");
        if (scanner.hasNextLine())
        {
          address = scanner.nextLine();
        }
        System.out.print(address);
        if (CityMap.validAddress(address))
          System.out.println("\nValid Address"); 
        else
          System.out.println("\nBad Address"); 
      }
      // Unit Test of CityMap Distance Method
      else if (action.equalsIgnoreCase("DIST")) 
      {
        String from = "";
        System.out.print("From: ");
        if (scanner.hasNextLine())
        {
          from = scanner.nextLine();
        }
        String to = "";
        System.out.print("To: ");
        if (scanner.hasNextLine())
        {
          to = scanner.nextLine();
        }
        System.out.print("\nFrom: " + from + " To: " + to);
        System.out.println("\nDistance: " + CityMap.getDistance(from, to) + " City Blocks");
      }
      
      System.out.print("\n>");
    }
    scanner.close();
  }
}

