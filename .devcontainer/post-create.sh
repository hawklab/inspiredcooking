dotnet restore
pushd Web
npm install
popd

dotnet ef database update --project Data -s Web
