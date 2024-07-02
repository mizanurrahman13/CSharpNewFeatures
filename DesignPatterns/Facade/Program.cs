/*
 * Facade Pattern - 𝐒𝐢𝐦𝐩𝐥𝐢𝐟𝐢𝐞𝐝


The Facade pattern is a structural pattern that provides a simplified interface to a complex system of classes,
subsystems, or APIs. 

The pattern encapsulates the complexity of the system behind a single class, called the facade, 
which acts as an entry point for clients to access the system's functionality.

𝐄𝐱𝐚𝐦𝐩𝐥𝐞: 
Imagine a large corporation with multiple departments, each responsible for a specific aspect of the business. 
There might be a sales department, a marketing department, an IT department, and a finance department.

When you have a question, complaint, or request, 𝐲𝐨𝐮 𝐜𝐚𝐥𝐥 𝐭𝐡𝐞 𝐜𝐮𝐬𝐭𝐨𝐦𝐞𝐫 𝐬𝐞𝐫𝐯𝐢𝐜𝐞 𝐝𝐞𝐩𝐚𝐫𝐭𝐦𝐞𝐧𝐭. 
What customer service department will do? 

Answer: 𝐅𝐨𝐫𝐰𝐚𝐫𝐝 𝐢𝐭 𝐭𝐨 𝐭𝐡𝐞 𝐚𝐩𝐩𝐫𝐨𝐩𝐫𝐢𝐚𝐭𝐞 𝐝𝐞𝐩𝐚𝐫𝐭𝐦𝐞𝐧𝐭.

• If you have a sales issue, the customer service representative forwards your issue to the sales department. 
• The sales department handles your issue and then sends a response back to the customer service representative. 
• The customer service representative then communicates the response back to you.

Similarly, the Facade pattern 𝐩𝐫𝐨𝐯𝐢𝐝𝐞𝐬 𝐚 𝐬𝐢𝐦𝐩𝐥𝐢𝐟𝐢𝐞𝐝 𝐢𝐧𝐭𝐞𝐫𝐟𝐚𝐜𝐞 𝐟𝐨𝐫 𝐜𝐥𝐢𝐞𝐧𝐭𝐬 𝐭𝐨 𝐢𝐧𝐭𝐞𝐫𝐚𝐜𝐭 𝐰𝐢𝐭𝐡 𝐚 𝐜𝐨𝐦𝐩𝐥𝐞𝐱 𝐬𝐲𝐬𝐭𝐞𝐦. 
The facade shields the clients from the complexity of the system's internals 
and provides a simplified view of the system's functionality.
 */
var customerService = new CustomerServiceFacade();

// When a customer inquiry arrives:
string customerRequest = "I have a sales issue.";
customerService.HandleCustomerInquiry(customerRequest);


