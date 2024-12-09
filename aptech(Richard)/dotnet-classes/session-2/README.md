# CRUD/HTTP Methods 

This document provides an overview of 9 commonly used CRUD/HTTP methods, along with a brief description of each.

## 1. GET
- **Description:** Retrieves data from a server without modifying it.  
- **Key Features:** Safe and idempotent.  
- **Example Use Case:** Fetching a list of products from an API.

## 2. POST
- **Description:** Sends data to the server to create a new resource.  
- **Key Features:** Typically used for creating new records.  
- **Example Use Case:** Submitting a form to create a new blog post.

## 3. PUT
- **Description:** Updates an existing resource or creates it if it doesn’t exist.  
- **Key Features:** Requires the entire resource to be sent for updates.  
- **Example Use Case:** Updating a user's profile information.

## 4. PATCH
- **Description:** Partially updates an existing resource.  
- **Key Features:** Sends only the fields that need to be updated.  
- **Example Use Case:** Changing just the email field in a user profile.

## 5. DELETE
- **Description:** Deletes a specific resource from the server.  
- **Key Features:** Irreversible action that removes data permanently.  
- **Example Use Case:** Deleting a user's account.

## 6. HEAD
- **Description:** Retrieves metadata (headers) of a resource without the response body.  
- **Key Features:** Useful for checking resource availability or server status.  
- **Example Use Case:** Verifying if a resource exists before downloading.

## 7. OPTIONS
- **Description:** Describes the communication options for a resource.  
- **Key Features:** Returns allowed HTTP methods for a specific URL.  
- **Example Use Case:** Checking which HTTP methods are supported by an API endpoint.

## 8. CONNECT
- **Description:** Establishes a tunnel to the server, often for secure communication.  
- **Key Features:** Typically used for HTTPS connections.  
- **Example Use Case:** Enabling SSL connections via a proxy server.

## 9. TRACE
- **Description:** Returns the received request for testing and debugging purposes.  
- **Key Features:** Useful for debugging API endpoint configurations.  
- **Example Use Case:** Debugging a misconfigured API endpoint.
