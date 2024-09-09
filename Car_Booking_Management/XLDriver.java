//Benjamin To
//501225316
// this class to create XLDriver as an inheritance if class Driver
// Type of this class will be set to XLDriver
public class XLDriver extends Driver {
    // create a special variable for seats
    private int seat;
    public XLDriver(String id, String name, String carModel, String licensePlate, int seat) {
        super(id, name, carModel, licensePlate);
        this.seat = seat;
        this.setType("XLDriver");
    }
   
    // getter for seat
    public int getSeat(){
      return seat;
    }
    public void printInfo()
    {
     super.printInfo();
     System.out.printf("\tSeat: %-2d",seat);
     System.out.printf("\tType: XLDriver");
    }
  //   public boolean equals(Object other)
  // {
  //   // check if other is an instance of a particular class or interface of Driver or not
  //   if (!(other instanceof XLDriver)){
  //     return false;
  //   }
  //   // Transfer other to class Drivers
  //   XLDriver user = (XLDriver)other;
   
  //   // check if 2 drivers are the same or not through their name and license plates
  //   return this.getName().equalsIgnoreCase(user.getName()) && this.getLicensePlate().equalsIgnoreCase(user.getName());
  // }
  

}
