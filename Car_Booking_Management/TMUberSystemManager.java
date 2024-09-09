//Benjamin To
//501225316
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;

/*
 * 
 * This class contains the main logic of the system.
 * 
 *  It keeps track of all users, drivers and service requests (RIDE or DELIVERY)
 * 
 */
public class TMUberSystemManager
{
  private ArrayList<User>   users;
  private ArrayList<Driver> drivers;
  private ArrayList<XLDriver> xlDrivers;

  private ArrayList<TMUberService> serviceRequests; 

  public double totalRevenue; // Total revenues accumulated via rides and deliveries
  
  // Rates per city block
  private static final double DELIVERYRATE = 1.2;
  private static final double RIDERATE = 1.5;
  private static final double XLRIDERATE = 2.0;
  // Portion of a ride/delivery cost paid to the driver
  private static final double PAYRATE = 0.1;
  // Portion of a ride/delivery cost paid to the driverXL
  private static final double PAYRATEXL = 0.2;

  //These variables are used to generate user account and driver ids
  int userAccountId = 900;
  int driverId = 700;

  public TMUberSystemManager()
  {
    users   = new ArrayList<User>();
    drivers = new ArrayList<Driver>();
    xlDrivers = new ArrayList<XLDriver>();
    serviceRequests = new ArrayList<TMUberService>(); 
    
    TMUberRegistered.loadPreregisteredUsers(users);
    TMUberRegistered.loadPreregisteredDrivers(drivers);
    TMUberRegistered.loadPreregisteredXLDrivers(xlDrivers);
    
    totalRevenue = 0;
  }

  // General string variable used to store an error message when something is invalid 
  // (e.g. user does not exist, invalid address etc.)  
  // The methods below will set this errMsg string and then return false
  String errMsg = null;

  public String getErrorMessage()
  {
    return errMsg;
  }
  
  // Given user account id, find user in list of users
  // Return null if not found
  public String getUser(String accountId)
  {
    for(User i :users){
      if (accountId.equals(i.getAccountId())){ // use the function equals to check 2 equalization in class User
        return i.getName();
      }
    }
    return null;
  }
  
  // Check for duplicate user
  private boolean userExists(User user)
  {
    
    for (User i : users){
      if (user.equals(i)){ // again use the function equals to check 2 equalization in class User
        return true;// return true if there's a user with the same name and address exists
      }
    }
    return false;
  }
  
 // Check for duplicate driver
 // similar stucture to function userExists
 private boolean driverExists(Driver driver)
 {
   for(Driver i : drivers){
    if(driver.equals(i)){ 
      return true;
    }
   }
   return false;
 }
 // Check for duplicate XLDriver
 private boolean XlDriverExists(XLDriver driver)
 {
   for(XLDriver i : xlDrivers){
    if(driver.equals(i)){ 
      return true;
    }
   }
   return false;
 }
  
  // Given a user, check if user ride/delivery request already exists in service requests
  private boolean existingRequest(TMUberService req)
  {
    for(TMUberService i : serviceRequests){
      if (i.equals(req)){
        return true;
      }
    }
    return false;
  }
  private void sortXLDriver(ArrayList<XLDriver> temp){
    Collections.sort(temp, new Comparator<XLDriver>() {
      public int compare(XLDriver user1, XLDriver user2){
        if(user1.getSeat() == user2.getSeat()){
          return 0;
        }
        return user1.getSeat()>user2.getSeat() ? 1:-1;
      }
    });
  }



  // Go through all drivers and see if one is available
  // Choose the first available driver
  // Return null if no available driver
  private Driver getAvailableDriver()
  {
   
      for (Driver i : drivers){
        if(i.getStatus() == Driver.Status.AVAILABLE){
          // if the driver is available then change the status to driving
          
          return i;
        }
      }
   
  
    return null;
  }
  // similar to getAvailablDriver but for XLdriver
  private XLDriver getAvailabXlDriver(int numPassengers){
    for(XLDriver i : xlDrivers){
      // to check if any XLdriver avilable and their car must have enough seats for the customers
      if(i.getStatus() == Driver.Status.AVAILABLE && i.getSeat()>=numPassengers){
        return i;
      }
    }
    return null;
  }

    // method namecheck
    private boolean namecheck(String name){
      if (name.equals(null) || name.length() == 0){
        
        return false;
      }
      return true;
    }

     // method walletcheck (positive number)
  private boolean walletcheck(double wallet){
    
    return wallet>=0 ? true:false;
  }
   
  // method to check for valid account ID
  private User accountIdcheck(String accountId){
    User set = null;
    for(User i : users){
      if(i.getAccountId().equals(accountId)){
        set = i;
      }
    }
    return set;
  }
  // method to check for valid distance
  private boolean checkDistance(String from, String to){
    if(CityMap.getDistance(from, to)>1){
      return true;
    }
    return false;
  }
  // method to check whether to have enough fund
  private double checkFund(User user,String from, String to){
    double fee = RIDERATE*CityMap.getDistance(from, to);
    if(user.getWallet()>=fee){
      return fee;
    }
    else{
      return -1;
    }
  }
  //method to check whether have enough fund for XL ride
  private double checkFundXL(User user,String from, String to){
    double fee = XLRIDERATE*CityMap.getDistance(from, to);
    if(user.getWallet()>=fee){
      return fee;
    }
    else{
      return -1;
    }
  }
  // method to check fund for delivery rate
  private double checkFundForDelivery(User user,String from, String to){
    double fee = DELIVERYRATE*CityMap.getDistance(from, to);
    if(user.getWallet()>=fee){
      return fee;
    }
    else{
      return -1;
    }
  }
  // method to check the valid food ID
  private boolean foodID (String foodOrderId){
   
    try {
      int number = Integer.parseInt(foodOrderId);
      return true;
    } catch (NumberFormatException e) {
      return false;
    }
  }
  // method to check a valid seats for a car : this must be a positive number and is smaller than 7
  private boolean seatCheck (int seat){
    if(seat<=0 || seat>6){
      return false;
    }
    return true;
  }

  // Print Information (printInfo()) about all registered users in the system
  public void listAllUsers()
  {
    System.out.println();
    
    for (int i = 0; i < users.size(); i++)
    {
      int index = i + 1;
      System.out.printf("%-2s. ", index);
      users.get(i).printInfo();
      System.out.println(); 
    }
  }

  // Print Information (printInfo()) about all registered drivers in the system
  public void listAllDrivers()
  {
    for (int i =0 ;i<drivers.size();i++){
      int index = i+1;
      System.out.printf("%-2s. ", index);
      drivers.get(i).printInfo();
      System.out.println(); 

    }
    // list all XlDriver
    for(int i = 0;i<xlDrivers.size();i++){
      int index = i+drivers.size()+1;
      System.out.printf("%-2s. ",index);
      xlDrivers.get(i).printInfo();
      System.out.println();
    }
  }

  // Print Information (printInfo()) about all current service requests
  public void listAllServiceRequests()
  {
    for(int i=0;i<serviceRequests.size();i++){
      int index = i+1;
      System.out.printf("%-2s. %s ", index,"-".repeat(40));
      serviceRequests.get(i).printInfo();
      System.out.println(); 
    }
  }

  // Add a new user to the system
  public boolean registerNewUser(String name, String address, double wallet)
  {
    // Fill in the code. Before creating a new user, check paramters for validity
    // See the assignment document for list of possible erros that might apply
    // Write the code like (for example):
    // if (address is *not* valid)
    // {
    //    set errMsg string variable to "Invalid Address "
    //    return false
    // }
    // If all parameter checks pass then create and add new user to array list users
    // Make sure you check if this user doesn't already exist!
    

    
    // create a temporary temp to perform some checks
    User temp = new User(TMUberRegistered.generateUserAccountId(users), name, address, wallet);
    // check the valid of name
    if(!namecheck(name)){
      errMsg = "Invalid User Name";
      return false;
    }
    // check the valid of address
    if(!CityMap.validAddress(address)){
      errMsg = "Invalid User Address";
      return false;
    }
    // check the valid wallet
    if(!walletcheck(wallet)){
      errMsg = "Invalid Money in Wallet";
      return false;
    }    
    // check if user already exist
    if(userExists(temp)){
      errMsg = "User Already Exists in System";
      return false;
    }
    // If all check pass then add new user to list
    else{
      users.add(temp);
      return true;}
  }


 

  // Add a new driver to the system
  public boolean registerNewDriver(String name, String carModel, String carLicencePlate)
  {
    // Fill in the code - see the assignment document for error conditions
    // that might apply. See comments above in registerNewUser

    // create a Driver variablie temp to perform check and add to drivers if success
    Driver temp = new Driver(TMUberRegistered.generateDriverId(drivers),name,carModel,carLicencePlate);

    // reuse the namecheck method as it is the same as REGUSER
    if(!namecheck(name)){
      errMsg = "Invalid Driver Name";
      return false;
    }
    // Analogous to driver name
    if(!namecheck(carModel)){
      errMsg = "Invalid Car Model";
      return false;
    }
    // Analogous to driver name
    if(!namecheck(carLicencePlate)){
      errMsg = "Invalid Car Licence Plate";
      return false;
    }
    if (driverExists(temp)){
      errMsg = "Driver Already Exists in System";
      return false;
    }

    drivers.add(temp);
    return true;
  }
  // Same as normal driver but register for XLdriver
  public boolean registerNewXLDriver(String name, String carModel, String carLicencePlate,int seat)
  {
    // Fill in the code - see the assignment document for error conditions
    // that might apply. See comments above in registerNewUser

    // create a Driver variablie temp to perform check and add to drivers if success
    Driver temp = new Driver(TMUberRegistered.generateDriverId(drivers),name,carModel,carLicencePlate);

    // reuse the namecheck method as it is the same as REGUSER
    if(!namecheck(name)){
      errMsg = "Invalid Driver Name";
      return false;
    }
    // Analogous to driver name
    if(!namecheck(carModel)){
      errMsg = "Invalid Car Model";
      return false;
    }
    // Analogous to driver name
    if(!namecheck(carLicencePlate)){
      errMsg = "Invalid Car Licence Plate";
      return false;
    }
    // number of seats check
    if(!seatCheck(seat)){
      errMsg = "Invalid seat";
      return false;
    }
    // check whether a driver has already exist or not
    if (driverExists(temp)){
      errMsg = "Driver Already Exists in System";
      return false;
    }
    // after perform all check as normal
    // create the XlDriver then perform the check on exist driver in list XLDriver
    XLDriver temp1 = new XLDriver(TMUberRegistered.generateXLDriverId(xlDrivers), name, carModel, carLicencePlate,seat);
    if(XlDriverExists(temp1)){
      errMsg = "Driver Already Exists in System";
      return false;
    }

    xlDrivers.add(temp1);
    // this method of sort modified the list of XLdriver in order
    // this help to get the driver that has the closest seats to the user request
    // For instance: If a user request a Xlcar and request for 2 seats, the system will match
    // with the car that has 2 seats rather than a car that has 6 seats.
    sortXLDriver(xlDrivers);
    return true;
  }
  

  // Request a ride. User wallet will be reduced when drop off happens
  public boolean requestRide(String accountId, String from, String to)
  {
    // Check for valid parameters
	// Use the account id to find the user object in the list of users
    // Get the distance for this ride
    // Note: distance must be > 1 city block!
    // Find an available driver
    // Create the TMUberRide object
    // Check if existing ride request for this user - only one ride request per user at a time!
    // Change driver status
    // Add the ride request to the list of requests
    // Increment the number of rides for this user

    //check valid ID
    if((accountIdcheck(accountId)==null)){
      errMsg = "User Account Not Found";
      return false;
    }

    // if ID is valid then create a variable to point to that user
    User tempUserRequeset =  accountIdcheck(accountId);
    // check valid distance 
    if(!checkDistance(from, to)){
      errMsg = "Insufficient Travel Distance";
      return false;
    }

    // check for valid address
    if(!CityMap.validAddress(from) || !CityMap.validAddress(to)){
      errMsg = "Invalid Address";
      return false;
    }
    
     // check for fund 
    if((checkFund(tempUserRequeset, from, to))<0){
      errMsg = "Insufficient Fund";
      return false;
    }
    // if fee valid then create a temporary variable to hold it
    double temporaryFee = checkFund(tempUserRequeset, from, to);
    // check whether there are available driver or not
    if(getAvailableDriver()==null){
      errMsg = "No Drivers Available";
      return false;
    }
    
    Driver tempDriver = getAvailableDriver();
   
    
     
    // Create the TMUberRide object
    TMUberRide tempTmUberRide = new TMUberRide(tempDriver, from, to, tempUserRequeset, CityMap.getDistance(from, to),temporaryFee);
    // check if this user are already having a ride or not
    if (existingRequest(tempTmUberRide)){
      errMsg = "User Already Has Ride Request";
      return false;
    }
    // change the status of the driver
    for(Driver i: drivers){
      if(i.equals(tempDriver)){
        i.setStatus(Driver.Status.DRIVING);
      }
    }
    // Increase the numbers of ride for this user
    for(User i : users){
      if(i.equals(tempUserRequeset)){
        i.addRide();
      }
    }
    //// Add the ride request to the list of requests
    serviceRequests.add(tempTmUberRide);


    
    

    return true;
  }
  
  // Request ride of XLDriver
  public boolean requestXlRide(String accountId, String from, String to,int numPassengers){
    //check valid ID
    if((accountIdcheck(accountId)==null)){
      errMsg = "User Account Not Found";
      return false;
    }

    // if ID is valid then create a variable to point to that user
    User tempUserRequeset =  accountIdcheck(accountId);
    // check valid distance 
    if(!checkDistance(from, to)){
      errMsg = "Insufficient Travel Distance";
      return false;
    }

    // check for valid address
    if(!CityMap.validAddress(from) || !CityMap.validAddress(to)){
      errMsg = "Invalid Address";
      return false;
    }
    
     // check for fund 
    if((checkFundXL(tempUserRequeset, from, to))<0){
      errMsg = "Insufficient Fund";
      return false;
    }
    // if fee valid then create a temporary variable to hold it
    double temporaryFee = checkFundXL(tempUserRequeset, from, to);
    // check whether there are available driver or not
    if(getAvailabXlDriver(numPassengers)==null){
      errMsg = "No Drivers Available";
      return false;
    }
    
    XLDriver tempDriver = getAvailabXlDriver(numPassengers);
   
    
     
    // Create the TMUberRide object
    TMUberRide tempTmUberRide = new TMUberRide(tempDriver, from, to, tempUserRequeset, CityMap.getDistance(from, to),temporaryFee,numPassengers);
    // check if this user are already having a ride or not
    if (existingRequest(tempTmUberRide)){
      errMsg = "User Already Has Ride Request";
      return false;
    }
    // change the status of the driver
    for(XLDriver i: xlDrivers){
      if(i.equals(tempDriver)){
        i.setStatus(Driver.Status.DRIVING);
      }
    }
    // Increase the numbers of ride for this user
    for(User i : users){
      if(i.equals(tempUserRequeset)){
        i.addRide();
      }
    }
    //// Add the ride request to the list of requests
    serviceRequests.add(tempTmUberRide);


    
    

    return true;
  }
 
  // Request a food delivery. User wallet will be reduced when drop off happens
  public boolean requestDelivery(String accountId, String from, String to, String restaurant, String foodOrderId)
  {
    // See the comments above and use them as a guide
    // For deliveries, an existing delivery has the same user, restaurant and food order id
    // Increment the number of deliveries the user has had
    //check valid ID
    if((accountIdcheck(accountId)==null)){
      errMsg = "User Account Not Found";
      return false;
    }

    // if ID is valid then create a variable to point to that user
    User tempUserRequeset =  accountIdcheck(accountId);
    // check valid distance 
    if(!checkDistance(from, to)){
      errMsg = "Insufficient Travel Distance";
      return false;
    }

    // check for valid address
    if(!CityMap.validAddress(from) || !CityMap.validAddress(to)){
      errMsg = "Invalid Address";
      return false;
    }
    if((checkFundForDelivery(tempUserRequeset, from, to))<0){
      errMsg = "Insufficient Fund";
      return false;
    }
    // if fee valid then create a temporary variable to hold it
    double temporaryFee = checkFundForDelivery(tempUserRequeset, from, to);
    //check for valid food ID
    if(!foodID(foodOrderId)){
      errMsg = "Invalid Request #";
      return false;
    }
    // check whether there are available driver or not
    if(getAvailableDriver()==null){
      errMsg = "No Drivers Available";
      return false;
    }
    // create a variable to store that driver
    
    Driver tempDriver = getAvailableDriver();

    //create a TMUberDelivery Object
    TMUberDelivery tempTmUberDelivery = new TMUberDelivery(tempDriver, from, to, tempUserRequeset, CityMap.getDistance(from, to), temporaryFee, restaurant, foodOrderId);
    if (existingRequest(tempTmUberDelivery)){
      errMsg = "User Already Has Delivery Request at "+restaurant +" with this "+foodOrderId+" Food Order";
      return false;
    }
    // change the status of the driver
    for(Driver i: drivers){
      if(i.equals(tempDriver)){
        i.setStatus(Driver.Status.DRIVING);
      }
    }
    // Increase the numbers of delivery for this user
    for(User i : users){
      if(i.equals(tempUserRequeset)){
        i.addDelivery();
      }
    }
    //// Add the ride request to the list of requests
    serviceRequests.add(tempTmUberDelivery);
    return true;
  }



  // Cancel an existing service request. 
  // parameter int request is the index in the serviceRequests array list
  public boolean cancelServiceRequest(int request)
  {
    if(request>serviceRequests.size()){
      errMsg = "Invalid request";
      return false;
    }
    //set the status of the driver become available again
    serviceRequests.get(request-1).getDriver().setStatus(Driver.Status.AVAILABLE);
    // decrease the number of ride or delivery base on the request
    if(serviceRequests.get(request-1).getServiceType().equals("DELIVERY")){
      serviceRequests.get(request-1).getUser().deDelivery();
    }
    else{
      serviceRequests.get(request-1).getUser().deRide();
    }
    // serviceRequests.get(request-1).getUser()
    serviceRequests.remove(request-1);
    return true;
  }
  
  // Drop off a ride or a delivery. This completes a service.
  // parameter request is the index in the serviceRequests array list
  public boolean dropOff(int request)
  {
    // See above method for guidance
    // Get the cost for the service and add to total revenues
    // Pay the driver
    // Deduct driver fee from total revenues
    // Change driver status
    // Deduct cost of service from user
    if(request>serviceRequests.size() || request <=0){
      errMsg = "Invalid request #";
      return false;
    }
    //create a temporary variable to store the request
    TMUberService tempService = serviceRequests.get(request-1);
    //create a temporary to hold the total fee that a customer has to pay
    double tempFee = tempService.getCost();
    //charge the customer
    tempService.getUser().payForService(tempFee);
    //create the fee that pat driver 
    double feeDriver = 0;
    //pay for the driver and change the driver status
    if (tempService.getDriver().getType().equals("Normal")){
    tempService.getDriver().pay(tempFee*PAYRATE);
    feeDriver = tempFee*PAYRATE;}
    // if the driver is a XLdriver then a diffirent payrate is applied
    else{
      tempService.getDriver().pay(tempFee*PAYRATEXL);
      feeDriver =tempFee*PAYRATEXL;
    }
    tempService.getDriver().setStatus(Driver.Status.AVAILABLE);
    //eliminate request out of list of service
    serviceRequests.remove(request-1);
    //add to total revenue
    totalRevenue+=tempFee-feeDriver;
    return true;
  }


  // Sort users by name
  // Then list all users
  public void sortByUserName()
  {
    Collections.sort(users, new Comparator<User>() {
           
      public int compare(User user1, User user2) {
          return user1.getName().compareTo(user2.getName());
      }
    
  }
 
  );
  listAllUsers();

    
  }

 

  // Sort users by number amount in wallet
  // Then ist all users
  public void sortByWallet()
  {
    Collections.sort(users, new Comparator<User>() {
           
      public int compare(User user1, User user2) {
          if(user1.getWallet() == user2.getWallet()){
            return 0;
          }
          return user1.getWallet() > user2.getWallet() ? 1:-1;
      }
  });
  listAllUsers();
  }
  // // Helper class for use by sortByWallet
  // private class UserWalletComparator 
  // {
  
  // }

  // Sort trips (rides or deliveries) by distance
  // Then list all current service requests
  public void sortByDistance()
  {
    Collections.sort(serviceRequests,new Comparator<TMUberService>() {
      public int compare(TMUberService user1, TMUberService user2){
        if(user1.getDistance() == user2.getDistance()){
          return 0;
        }
        return user1.getDistance() > user2.getDistance() ? 1:-1;
      }
    });
    listAllServiceRequests();
  }

}
