from django.contrib import admin
from customer_subsystem.models import City, Hotel, Images, Rating, Reservation, RoomReview, RoomType
# Register your models here.

admin.site.register(City)
admin.site.register(Hotel)
admin.site.register(Images)
admin.site.register(Rating)
admin.site.register(Reservation)
admin.site.register(RoomReview)
admin.site.register(RoomType)

