//Benjamin To
//501225316
import java.util.Arrays;
import java.util.Scanner;

// The city consists of a grid of 9 X 9 City Blocks

// Streets are east-west (1st street to 9th street)
// Avenues are north-south (1st avenue to 9th avenue)

// Example 1 of Interpreting an address:  "34 4th Street"
// A valid address *always* has 3 parts.
// Part 1: Street/Avenue residence numbers are always 2 digits (e.g. 34).
// Part 2: Must be 'n'th or 1st or 2nd or 3rd (e.g. where n => 1...9)
// Part 3: Must be "Street" or "Avenue" (case insensitive)

// Use the first digit of the residence number (e.g. 3 of the number 34) to determine the avenue.
// For distance calculation you need to identify the the specific city block - in this example 
// it is city block (3, 4) (3rd avenue and 4th street)

// Example 2 of Interpreting an address:  "51 7th Avenue"
// Use the first digit of the residence number (i.e. 5 of the number 51) to determine street.
// For distance calculation you need to identify the the specific city block - 
// in this example it is city block (7, 5) (7th avenue and 5th street)
//
// Distance in city blocks between (3, 4) and (7, 5) is then == 5 city blocks
// i.e. (7 - 3) + (5 - 4) 

public class CityMap
{


  // Checks for a valid address
  public static boolean validAddress(String address)
  {
    // Fill in the code
    // Make use of the helper methods above if you wish
    // There are quite a few error conditions to check for 
    // e.g. number of parts != 3
    // false if address is null or empty
    if(address == null || address.isEmpty()){
      return false;
    }
    // split the address
    String [] addresses = address.split(" ");
    // check if address contains 3 parts
    if(addresses.length != 3){
      return false;
    }
    // check whether Street/Avenue residence numbers is a digit or not
    try {
      Integer.parseInt(addresses[0]);

    } catch (NumberFormatException e) {
      return false;
    }
    // check if Street/Avenue residence numbers are 2 digits
    if(!(Integer.parseInt(addresses[0])>0 && Integer.parseInt(addresses[0])<92)){
      return false;
    }
    // check part 3 whether it is "avenue" or "street"
    if(!(addresses[2].equalsIgnoreCase("street") || addresses[2].equalsIgnoreCase("avenue"))){
      return false;
    }
    // check part 2 must be 'n'th or 1st or 2nd or 3rd
    
    String numPart = addresses[1].substring(0,1);
    //check the number part is a digit or not
    try {
      int intNumPart = Integer.parseInt(numPart);
      // first check if the number is in in range(10)
      if(!(intNumPart>0 && intNumPart<10)){
        return false;
      }
      //then check the tail
    String strPart = addresses[1].substring(1);
    if(intNumPart == 1){
      return strPart.equalsIgnoreCase("st");}
    else if(intNumPart == 2){
      return strPart.equalsIgnoreCase("nd");
    }
    else if(intNumPart == 3){
      return strPart.equalsIgnoreCase("rd");
    }
    else{
      return strPart.equalsIgnoreCase("th");
    }
    } catch (NumberFormatException e) {
      return false;
    }
    
   
    
  }

  // Computes the city block coordinates from an address string
  // returns an int array of size 2. e.g. [3, 4] 
  // where 3 is the avenue and 4 the street
  // See comments at the top for a more detailed explanation
  public static int[] getCityBlock(String address)
  {
    int[] block = {-1, -1};
    String [] addresses = address.split(" ");
    if(addresses[2].equalsIgnoreCase("avenue")){
      block[0] = Integer.parseInt(addresses[1].substring(0,1));
      block[1] = Integer.parseInt(addresses[0].substring(0,1));
    }
    else{
      block[1] = Integer.parseInt(addresses[1].substring(0,1));
      block[0] = Integer.parseInt(addresses[0].substring(0,1));

    }
    // Fill in the code
    return block;
  }
  
  // Calculates the distance in city blocks between the 'from' address and 'to' address
  // Hint: be careful not to generate negative distances
  
  // This skeleton version generates a random distance
  // If you do not want to attempt this method, you may use this default code
  public static int getDistance(String from, String to)
  {
    // Fill in the code or use this default code below. If you use
    // the default code then you are not eligible for any marks for this part
    int[] addressFrom = getCityBlock(from);
    int[] addressTo = getCityBlock(to);
    return Math.abs(addressFrom[0]-addressTo[0])+Math.abs(addressFrom[1]-addressTo[1]);
  }
  // Get city zone
  public int getCityZone(String address){
    if (!validAddress(address)){
      return -1;
    }
    int [] temp = CityMap.getCityBlock(address);
    if (1<=temp[0]&&temp[0]<=5 && 6<=temp[1]&&temp[1]<=9){
      return 0;
    }
    if(6<=temp[0]&&temp[0]<=9 && 6<=temp[1]&&temp[1]<=9){
      return 1;
    }
    if(6<=temp[0]&&temp[0]<=9 && 1<=temp[1]&&temp[1]<=5){
      return 2;
    }
    else{
      return 3;
    }
  }
}
