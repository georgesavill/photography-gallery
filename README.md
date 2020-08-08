# photography-gallery

Simple ASP.NET Core website for the display and download of photography images in a gallery format.

Images are stored in wwwroot/images directory, and only .jpg files are supported. Use the [photography-gallery-image-resizer](https://github.com/georgesavill/photography-gallery-image-resizer) to generate thumbnail and preview images 

To deploy with docker:
```
docker build -t photo-gallery .
```
```
docker run -d -p 8080:80 -p 8443:442 photo-gallery
```
Or use docker-compose.