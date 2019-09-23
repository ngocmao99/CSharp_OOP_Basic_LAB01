# **ENCAPSULATION- _Problem 02: Salary Increas_**
## **Problem 02**
### _**Salary Increase**_
>  _**NOTE:**_ Create a public _**Startup**_ class with the namescape _**PersonInfo**_.   
 
**Refactor the project from the last task.**  
Read a _**Person**_ with their names, age and salary. Read the percentage of the bonus to every Person salary. People younger than 30 _**get half the increase**_. Expand **Person** from the previous task.
New **fields** and **methods**:  
* salary: decimal
* IncreaseSalary(decimal percentage)  

## **Inputs and Outputs**  
**Input** | **Output**
----------|-----------
5         | Asen Ivanov receives 2640.00 leva.
Asen Ivanov 65 2200 | Boiko Borisov receives 3999.60 leva.
Boiko Borisov 57 3333 | Ventsislav Ivanov receives 600.00 leva.
Ventsislav Ivanov 27 600 | Asen Harizanoov receives 799.99 leva.
Boiko Angelov 35 559.4 | 
20 |

## **Solution**
1. Using the _**Person class**_ that created in the previous problem.  
2. Adding a new _**private**_ field for salary and _**refactor constructor**_, which will update salary with a bonus into the _**Person class**_. 
   ![Imgur](https://i.imgur.com/fvgsAGP.png) 
   ![Imgur](https://i.imgur.com/OiIDuno.png)  
3. Refactor the _**ToString() method for this problem.  
   ![Imgur](https://i.imgur.com/fY7d6Nm.png)  
4. In _**Program class**_, we using _**List**_ to contain the Person objects.
   ![Imgur](https://i.imgur.com/V2H5IgU.png)    
5. Using the _**for**_ loops to create the new objects that contained by _**List**_.  
   ![Imgur](https://i.imgur.com/4zJ4p4O.png)
6. Calling _**IncreaseSalary**_ method to calculate the salary for each person.
   ![Imgur](https://i.imgur.com/f7yHHw4.png)  

## **The result**
![Imgur](https://i.imgur.com/M6vEpUH.png)
