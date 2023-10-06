## MFPE: Return Order Management Portal 

### POD Members

Name	    		Employee ID		Contribution
-------------------------------------------------------------------------------------------------------------------------------------------
Harsh Goyal		907360		Component Microservice and Return Order Portal (Front – End)
Narne Lakshmi Narasimha Sai	905256		Authorization Microservice and Return Order Portal (Functionality)
Utsav Tiwari		907371		Packaging and Delivery Microservice
Vishesh Sharma		907373		Payment Microservice


---
**##OBJECTIVE##**
A leading Supply chain Management Organization wants to automate the return orders, by classifying them to repair or replacement.
Repair is for all main or integral parts of their product. Replacement is for accessories. 


## **MICRO SERVICES FUNCTIONALITY**

Component Processing Microservice:
1. Determine if the request is for Repair or Replacement 

2. Determine the repair or replacement cost along with the consideration if it’s a priority request or not. Determine the date of process completion 

3. Invoke Packaging and Delivery service to determine the cost and date of delivery 

4. Return the Processing response detail object


Packaging and Delivery Microservice:
1. Determine the packaging and delivery charge for the item based on a pre-defined logic 

2. Provide the expected date of delivery.

Payment Microservice:
1. Gets the processing charge and the Credit card details as input. Deducts the amount and provides the result message if the deduction succeeded or not

Authorization Microservice:
1. This microservice is used with anonymous access to Generate JWT

Return Order Portal:
1. Login 

2. Provide details for Return order 

3. View the processing detail 

4. Confirm processing

---

---

##WORKING##

Step 1: Run all the microservices
Step 2: Run the Return Order Portal.
Step 3: Enter Login Details to authorise the user and press login.
Step 4: Enter Component Details, Name, Contact Number, Credit Card Number, etc. and press submit.
Step 5: Verify the process response details and confirm the Request.
Step 6: The request is confirmed and the amount is deducted from the card.
