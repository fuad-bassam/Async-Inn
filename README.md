#  Hotel Chain API

**By Fuad Abuawad**

**Date : 20/4/2022**

 #|s
 ---|---
1|[Description](#description)
1|[ERD](#erd)
1|[Tables description](#tables-description)
1|[Controllers in project](#controllers)
1|[Routeing in project](#route)



## Description 

This project is a **`DotNet MVC AND API`** project for Hotel chain named **Async Inn** , that have the main **CRUD** operation and access for the hotel.

-----    
## ERD


![img](./image/ERD_Hotel.png)

---

## Tables description


for Hotels we create 9 tables with ability to add more in futuer version of this API

1. **HotelBranches**
this one of the important table in our diagram it have the atripute for eath branche in the Hotel chain.


 **Relations:**  
  - each branch have many rooms.
  - each branch have many employees.
         


![img](./image/HB_table.PNG)     
2. **Rooms**
    
this table have the data for each room in hotel.

hotelId,roomId : is a Composite Keys declare from combine between hotelId & roomId ,because maybe two have the romeid in different branches (example: the room in hotel branch 1 have roomid `101` and another room in hotel branch 2 have roomid `101` so we create a unique Composite Keys for eath room)


**Relations:**


  - eath room have many amenities and eath amenities can be in many rooms.
  - eath room is prat of hotel.



![img](./image/R_table.PNG)


3. **Amenities** 

this table for the each room has to offer from amenities.

**Relations:**
  - eath room have many amenities and eath amenities can be in many rooms.


![img](./image/A_table.PNG)  
   
4. **RoomsAmenities**


it is a entity joint table between Rooms table and Amenities table


![img](./image/RA_table.PNG)  
5. **People**


every person in the hotal have a personsl infromation we srot it in one table.

**Relations:**
    
  - visitors and employees inhert personal data from People table.      


![img](./image/P_table.PNG)


6. **Visitors** 

have the data from people tabel for personal infromation and have to attribute

 - days : for the nunber of days that the visitor stay in his visit (from the frist day ) 
 - daysTotal : to store teh total of days that user spend in his life in the hotel and to konw the loyal visitor and give them some privilege. 


**Relations:**

  - inhert from people a pirsonal information.
  - every visitor can reserve many room. (example: he reserve room `103` in branch 1 and lift his bags in this room and go to another branch in another room for just one day without taking his bags from the first room ).
      
![img](./image/v_table.PNG)  

7. **Employees** 
    
have the data from people tabel for personal eath employee and the information of his work 

**Relations:**
  - inhert from people a pirsonal information
  - evry hotel branch have many employee
  - each employee have s schedule for the day that they go to wrok and in evry schedule there are many employees work in this day.

![img](./image/E_table.PNG)

8. **WorkTime**

this table for the work schedule for all employees and have three attributes

  - WorkDays: to get if they arrived to work or the employee have day work or not.
  - shift: to have any time if day thy have to wrok.
  - date: to record the date for evry day.     
     
    **Relations:**
   - each employee have s schedule for the day that they go to wrok and in evry schedule there are many employees work in this day.

![img](./image/W_table.PNG)

9. **EmployeesWorkTime** 


it is a entity joint table between Employees table and WorkTime table.


![img](./image/EW_table.PNG)

 
 
-----   
## controllers 

we have three controllers in our project

- AmenitiesController
- HotelBranchesController
- RoomsController

each controller have the CRUD operation for his interface (we use "Dependency Injection" to improve the code).

----    
## Route

for the route in our project we have :

- `/` : this to print (Hello World!)
- `/hey` : this to print (booyah)
- Controllers.

 1. **AmenitiesController**
     -  // POST: `api/Amenities` (to Create new Amenities, take in body JSON of class type `Amenities`) like.
            
     ```
    {
    "amenitiesId": 51,
    "name": "ocean view",
    "description": "have a view from the window on the ocean.",
    "price": 35
    }
     ```      

     -  // GET: `api/Amenities` (to Get all Amenities)
     -  // GET: `api/Amenities/21` (to Get Amenities depend on resorse `key`)
     -  // PUT: `api/Amenities/21` (to Update Amenities depend on  resorse `key` and take in body json of class type `Amenities`;
     -  // DELETE: `api/Amenities/21` (to delete data from Amenities depend on resorse `key`)
     



2. **HotelBranchesController**
      -  // POST: `api/HotelBranches` (to Create new Hotel, take in body JSON of class type `HotelBranches`) like.
            
     ```
    {
        "hotelId": 3,
        "name": "Downtown Branch",
        "city": "jordan",
        "state": "amman",
        "address": "Downtoun-ALsame street ",
        "phoneNum": "00963323423212",
        "roomsNum": 30
    }
     ```      

     -  // GET: `api/HotelBranches` (to Get all HotelBranches)
     -  // GET: `api/HotelBranches/1` (to Get HotelBranches depend on resorse `key`)
     -  // PUT: `api/HotelBranches/1` (to Update HotelBranches depend on  resorse `key` and take in body json of class type `HotelBranches`;
     -  // DELETE: `api/HotelBranches/1` (to delete data from HotelBranches depend on resorse `key`)
     


3. **RoomsController**
     -  // POST: `api/Rooms` (to Create new Rooms, take in body JSON of class type `Rooms`) like.
            
     ```
       {
        "hotelId": 2,
        "roomId": 103,
        "nickName": "Restful Rainier",
        "space": 2,
        "price": 29.9,
       }
     ```      

     -  // GET: `api/Rooms` (to Get all Rooms)
     -  // GET: `api/Rooms/1/101` (to Get Rooms depend on composite key as resorse first`hotelId`, then `roomId`)
     -  // PUT: `api/Rooms/1/101` (to Update Rooms depend on composite key as resorse first`hotelId`, then `roomId` and take in body json of class type `HotelBranches`;
     -  // DELETE: `api/Rooms/1/101` (to delete data from Rooms depend on composite key as resorse first`hotelId`, then `roomId`)
     -  // GET: `api/Rooms/1/101/Amenity/31` (to create new RoomsAmenities take in body JSON of class type `RoomsAmenities`)

    ```
      {
        "roomId": 101,
        "hotelId": 2,
        "amenitiesId": 21,
        "canRemove": true
      }
     ```  
     -  // DELETE: `api/Rooms/1/101/Amenity/31` (to delete data from RoomsAmenities depend on composite key as resorse first`hotelId`, then `roomId` the `amenityId`)