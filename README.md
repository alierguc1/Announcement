**AnnouncementAPI**


- Projeyi ayağa kaldırabilmek için öncelikle `AnnouncementAPI.AuthServer` ve `AnnouncementAPI.HttpApi.Host` modüllerinde bulunan `appsettings.json` dosyalarını yapılandırmanız gerekmektedir. 
- `appsettings.json` dosyalarını yapılandırdıktan sonra, EF Core Migration ları eklemeniz gerekmektedir.
- Proje'de redis kullanıldığı için, docker üzerinden container'ı yüklemeniz ve redis için gerekli konfigürasyonları'da yapmanız gerekmektedir.
  Docker üzerinden redis kurulumu için; `docker run -d -p 6379:6379 — name annouchmentapi-redis redis` yapabilirsiniz.
- Redis verilerini görselleştirebilmek için, Redis Insight kurabilirsiniz. Docker üzerinden Redis Insight Kurulumu için; `docker run -v redisinsight:/db -p 8001:8001 redislabs/redisinsight:latest`
  

