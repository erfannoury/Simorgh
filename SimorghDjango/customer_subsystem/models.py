# -*- coding: utf-8 -*-
from django.db import models

# Create your models here.
class City(models.Model):
    name = models.CharField(max_length=100)

class Hotel(models.Model):
    name = models.CharField(max_length=100)
    address = models.TextField()
    longitude = models.FloatField()
    latitude = models.FloatField()
    description = models.TextField(null=True, blank=True)
    star = models.SmallIntegerField(max_length=5)
    city = models.ForeignKey(City)

class RoomType(models.Model):
    title = models.CharField(max_length=100)
    description = models.TextField()
    hotel = models.ForeignKey(Hotel)
    capacity = models.IntegerField()
    price = models.FloatField()

class Images(models.Model):
    file_path = models.CharField(max_length=100)
    hotel = models.ForeignKey(Hotel, null=True, blank=True)
    room_type = models.ForeignKey(RoomType, null=True, blank=True)

class Reservation(models.Model):
    reservation_time = models.DateTimeField()
    checkin_time = models.DateTimeField()
    checkout_tiem = models.DateTimeField()
    traveller = models.ForeignKey('user_subsystem.Account')
    roomType = models.ForeignKey(RoomType)
    quantity = models.IntegerField()

class Rating(models.Model):
    traveller = models.OneToOneField('user_subsystem.Account')
    hotel = models.ForeignKey(Hotel)
    staff_behavior = models.SmallIntegerField(max_length=10)
    room_clearliness = models.SmallIntegerField(max_length=10)
    outdoor_clearliness = models.SmallIntegerField(max_length=10)
    prestige = models.SmallIntegerField(max_length=10)
    food_quality = models.SmallIntegerField(max_length=10)
    environment = models.SmallIntegerField(max_length=10)
    price_quality = models.SmallIntegerField(max_length=10)
    overall = models.SmallIntegerField(max_length=10)
    hotel_review = models.TextField()

class RoomReview(models.Model):
    roomType = models.ForeignKey(RoomType)
    review_date = models.DateTimeField()
    review = models.TextField()
    rate_up = models.SmallIntegerField(default=0)
    rate_down = models.SmallIntegerField(default=0)
    is_confirmed = models.BooleanField(default=False)