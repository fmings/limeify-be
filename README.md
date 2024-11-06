<h1 align="center" style="font-weight: bold;">Limeify API 🎧</h1>

<p align="center">
<a href="#technologies">Technologies</a> | 
<a href="#getting-started">Getting Started</a> | 
<a href="#api-endpoints">API Endpoints</a> | 
<a href="#postman-documentation"> Postman Documentation</a> |
<a href="#colab"> Collaborators</a>
</p>

<p align="center">This is the server-side repo for the full-stack app, Limeify — a playlist app that gives users a central, personalized space to easily create, manage, and customize playlists.</p>

<h2 id="technologies">💻 Technologies</h2>

- C#
- .NET
- Entity Framework Core
- Moq
- xUnit
- PostgreSQL
- pgAdmin
- Swagger
- Postman

<h2 id="getting-started">🚀 Getting started</h2>

<h3>Prerequisites</h3>

For this project to run successfully, you'll need the following:

- [.NET](https://dotnet.microsoft.com/en-us)
- [PostgreSQL](https://www.postgresql.org/download)
- [pgAdmin](https://www.pgadmin.org)

<h3>1. Clone the Repo</h3>

Clone this repo using this command in your terminal:

```bash
git clone https://github.com/fmings/limeify-be.git
```

<h3>2. Install Required Packages</h3>

Once the repository is cloned, navigate to the project directory in your terminal and run the following commands to install necessary packages:

```bash
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 6.0
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0
```

<h3>3. Set Up Secrets for PostgreSQL Connection</h3>

To store sensitive connection details, initialize the secret storage with:

```bash
dotnet user-secrets init
```

Then, set the connection string for your PostgreSQL database (replace with your actual PostgreSQL password):

```bash
dotnet user-secrets set "LimeifyDbConnectionString" "Host=localhost;Port=5432;Username=postgres;Password=<your_postgresql_password>;Database=Limeify"
```

<h3>4. Apply Migrations to the Database</h3>

Run the following command to apply the database migrations:

```bash
dotnet ef database update
```

This will create the necessary tables and schema in your PostgreSQL database.

<h3>5. Run the Solution</h3>

Launch the solution. Swagger should automatically launch and provide you with the API documentation.

<h2 id="api-endpoints">📍 API Endpoints</h2>

| Route               | Description                                          
|----------------------|-----------------------------------------------------
| <kbd>GET /api/artists</kbd>     | Retrieve a list of all artists
| <kbd>GET /api/artists/{id}</kbd>     | Retrieve the details of a single artist
| <kbd>GET /api/categories</kbd>     | Retrieve a list of all playlist categories
| <kbd>GET /api/playlists</kbd>     | Retrieve a list of all playlists
| <kbd>POST /api/playlists</kbd>     | Add a playlist
| <kbd>GET /api/playlists/public</kbd>     | Retrieve a list of all public playlists
| <kbd>GET /api/user/{uid}/playlists</kbd>     | Retrieve a list of a specific user's playlists
| <kbd>GET /api/playlists/{id}</kbd>     | Retrieve the details of a single playlist
| <kbd>PUT /api/playlists/{id}</kbd>     | Update the details of a playlist
| <kbd>DELETE /api/playlists{id}</kbd>     | Delete a playlist
| <kbd>GET /api/songs</kbd>     | Retrieve a list of all songs
| <kbd>GET /api/songs/{id}</kbd>     | Retrieve the details of a single song
| <kbd>GET /api/songs/search</kbd>     | Search songs
| <kbd>POST /api/songs/{songId}/add-to-playlist/{playlistId}</kbd>     | Add a song to a playlist
| <kbd>DELETE /api/songs/{songId}/remove-from-playlist/{playlistId}</kbd>     | Delete a song to a playlist

<h2 id="postman-documentation">📄 Postman Documentation</h2>

Check out the [Limeify Postman Documentation](https://documenter.getpostman.com/view/39137391/2sAXxY48sT) to learn more about the API routes and see examples of how each request and response should look.

<h2 id="colab">🤝 Collaborators</h2>

<p>Special thank you for all people that contributed for this project.</p>
<table>
<tr>

<td align="center">
<a href="https://github.com/fmings">
<img src="https://avatars.githubusercontent.com/u/150978100?v=4" width="100px;" alt="Felicia Mings Profile Picture"/><br>
<sub>
<b>Felicia Mings</b>
</sub>
</a>
</td>

<td align="center">
<a href="https://github.com/jessefrench">
<img src="https://avatars.githubusercontent.com/u/106822556?v=4" width="100px;" alt="Jesse French Profile Picture"/><br>
<sub>
<b>Jesse French</b>
</sub>
</a>
</td>

<td align="center">
<a href="https://github.com/Zpcolburn">
<img src="https://avatars.githubusercontent.com/u/144184847?v=4" width="100px;" alt="Zach Colburn Profile Picture"/><br>
<sub>
<b>Zach Colburn</b>
</sub>
</a>
</td>

</tr>
</table>
