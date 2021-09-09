dotnet restore
pushd Web
npm install
popd

dotnet ef database update --project Data -s Web --connection "Server=localhost;Database=RecipesDb;User Id=SA;Password=P@ssw0rd"
