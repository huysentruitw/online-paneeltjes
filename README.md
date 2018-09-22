# Online Paneeljes

## Database

### Create migrations

Open the Package Manager Console, set Paneeltjes.WebApp as Default project, then:

    Add-Migration {migration-name} -Project Paneeltjes.Data

### Update database

Open the Package Manager Console, set Paneeltjes.WebApp as Default project, then:

    Update-Database -Project Paneeltjes.Data
