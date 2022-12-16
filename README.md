# Create Penneo Webhooks

This is a simple console application for creating webhook subscriptions with the Penneo API.
It was built using the official [Penneo .NET SDK](https://github.com/Penneo/sdk-net) and [Sharprompt](https://github.com/shibayan/Sharprompt). 

## Requirements
* A Penneo API key and secret
* An endpoint for the webhook subscription
* A topic for the webhook 

## Build and run the application
1. Clone this repository or download the code as a ZIP file
2. Open a command prompt and navigate to the directory where the code was saved
3. Run `dotnet restore` to install the required packages
4. Run `dotnet run` to run the application

### ...Or alternatively
You can also download and run the latest release for your system under releases.

## Usage
1. Enter your Penneo API key, secret, and desired environment (e.g. 'staging', 'sandbox' or 'app') when prompted.
2. Enter the endpoint and topic for the webhook subscription when prompted.
3. The application will create a webhook subscription with the provided endpoint and topic using the Penneo API.
4. You will be prompted to enter a confirmation token - this token will be part of the message sent to the endpoint you provided.
5. The application will attempt to confirm the webhook subscription using the provided token and the Penneo API.
6. The application will print `Success!` if the confirmation was successful, or an error message if there was a problem.


