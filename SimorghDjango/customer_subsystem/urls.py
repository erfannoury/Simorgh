from django.conf.urls import patterns, url
from django.conf import settings
from customer_subsystem import views

urlpatterns = patterns('',
                       url(r'^$', views.index, name = "index"),
                       url(r'^search/$', views.search, name = "search"),
                       )

