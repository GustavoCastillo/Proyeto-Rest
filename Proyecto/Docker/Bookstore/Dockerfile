FROM mcr.microsoft.com/mssql/server:2017-latest

ARG SA_PASSWORD
ENV SA_PASSWORD=Password.123
ARG ACCEPT_EULA
ENV ACCEPT_EULA=Y 

COPY import-data.sh /usr/src/app/
COPY script.sql /usr/src/app/

# Grant permissions for the import-data script to be executable
RUN ( /opt/mssql/bin/sqlservr --accept-eula & ) | grep -q "Service Broker manager has started" \
    && /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P $SA_PASSWORD -i /usr/src/app/script.sql \
    && pkill sqlservr 

# SQL Server on Linux: https://docs.microsoft.com/en-us/sql/linux/sql-server-linux-setup-tools?view=sql-server-2017

#### Docker commands
# cd Server/sql_server/adventure_works
# docker build --rm -t adventure_works:latest . 
# docker run -e 'ACCEPT_EULA=Y' -e 'SA_Password=Password.123' -p 1433:1433 --name=sql1 -d adventure_works:latest
# docker logs -f 48505...
# data source=localhost;initial catalog=Adventureworks;persist security info=True;user id=sa;password=Password.123;MultipleActiveResultSets=True;App=EntityFramework

### Linux/SQL Server commands 
# cat /etc/*release
# export PATH="$PATH:/opt/mssql-tools/bin"
# sqlcmd -S localhost -U SA -P Password.123
# select getdate();

## Azure CLI commands
# Installing: https://docs.microsoft.com/en-us/cli/azure/get-started-with-azure-cli?view=azure-cli-latest

# az aks install-cli
# az login --use-device-code
# az account list --output table
# az account set --subscription "YOUR SUSCRIPTION NAME"

# az acr build --image samples/mywebapi:latest --registry myDemos --file Server/MyWebAPI/Dockerfile .