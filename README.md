# SaaS Bot Backend

This project aims to be the backend support to merge all the shared resources within this organization.

### Prerequisites

This project requires you to have .NET SDK installed
- [.NET SDK >= 8.0](https://dotnet.microsoft.com/en-us/download)

### Clone and use this repository

**WARNING: this is not a guide on contributing to this repository**

This repository contains the .NET project within a solution, all you need to do is

1. Clone the project
    ```bash
    git clone https://github.com/DiscordSaaSBot/SaaSBotBackend
    ```

2. Restore the packages
    ```bash
    dotnet restore
    ```

3. You can then build the project
    ```bash
    dotnet build .
    ```

**WARNING: this project is bare bones and is most likely subject to change**

## Deployment

To deploy this in a live system you can use docker, there is a Dockerfile in this project, you can use
to deploy this into your server, you might want to configure a workflow
or simply build the docker file and run it with docker, please see [this guide](https://docs.docker.com/get-started/02_our_app/).

## Contributing

Please read [CONTRIBUTING.md](CONTRIBUTING.md) for details on our code
of conduct, and the process for submitting pull requests to us.

## Versioning

We use [Semantic Versioning](http://semver.org/) for versioning. For the versions
available, see the [tags on this
repository](https://github.com/PurpleBooth/a-good-readme-template/tags).

## License

This project is licensed under the [Apache License Version 2.0](LICENSE)