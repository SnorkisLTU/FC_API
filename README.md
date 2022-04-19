# FootballClub_API

# Start Web Service

Clone Git Repository:
```
git clone https://github.com/SnorkisLTU/FC_API
```
Change Directory:
```
cd FC_API
```
Build Docker Image:
```
docker build -f FootballClubs/Dockerfile -t fc_api .
```
Run Docker Container
```
docker run -it --rm -p 80:80 fc_api
```
