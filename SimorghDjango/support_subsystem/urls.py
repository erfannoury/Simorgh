from django.conf.urls import patterns, url
from django.conf import settings
from support_subsystem import views

urlpatterns = patterns('',
                       url(r'^$', views.index, name = "index"),
                       )
