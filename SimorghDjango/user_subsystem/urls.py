from django.conf.urls import patterns, url
from django.conf import settings
from user_subsystem import views

urlpatterns = patterns('',
                       url(r'^logout/$', views.logout_user, name = "logout"),
                       url(r'^register/$', views.register_user, name = "register"),
                       url(r'^profile/$', views.profile_user, name = "profile"),
                       url(r'^profile/edit$', views.edit_user, name = "edit"),
                       # url(r'^profile/list_reservation', views.list_reservation, name = "list_reservation"),
                       url(r'^profile/change_password$', 'django.contrib.auth.views.password_change', {'post_change_redirect' : 'accounts:profile'}, name = "change_password"),
                       url(r'^login/$', 'django.contrib.auth.views.login', {'template_name':'accounts/login.html'}, name = "login"),

                       )
