from django.contrib import admin
from user_subsystem.models import Account, RegistrationConfirmation, TravellerUser
# Register your models here.

admin.site.register(Account)
admin.site.register(RegistrationConfirmation)
admin.site.register(TravellerUser)
