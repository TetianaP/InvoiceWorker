# Invoicr-App

The application consumes an Invoice event feed which Xero provides and creates a custom text file for each newly created invoice.


## Local Setup

1. Download and install the `.NET 5` SDK. Link [here](https://dotnet.microsoft.com/download)
2. Clone this repository.
3. Use the following commands to build and run the app.
    ```bash
    cd Invoicr-App

    # to build the app
    dotnet build

    # to run the app
    dotnet run --project Invoicr-App

    # to run tests
    dotnet test
    ```