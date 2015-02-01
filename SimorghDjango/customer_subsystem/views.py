# -*- coding: utf-8 -*-
from django.shortcuts import render
from customer_subsystem.models import Hotel, City, Reservation, Rating, RoomReview, RoomType
from django.db.models import Q

# Create your views here.

def index(request):
    print('hello')
    return render(request, 'customer_subsystem/index.html', {})

def search(request):
    if request.method == "GET":
        q = request.GET['q']
        hotels = Hotel.objects.all()
        hotels = Hotel.objects.filter(Q(city__name__contains=q) | Q(address__contains=q) | Q(description__contains=q))
        if (len(hotels) == 0):
            return render(request, 'customer_subsystem/search_result.html', {"notfound" : True})
        return render(request, 'customer_subsystem/search_result.html', {"hotels" : hotels})
    return render(request, 'customer_subsystem/search_result.html', {"notfound" : True})