from django.conf.urls import patterns, include, url
from django.contrib import admin

admin.autodiscover()

urlpatterns = patterns('',
    # Examples:
    # url(r'^$', 'SimorghDjango.views.home', name='home'),
    # url(r'^blog/', include('blog.urls')),

    url(r'^admin/', include(admin.site.urls)),
    url(r'^', include('customer_subsystem.urls', 'customer')),
    url(r'^hotel_mg/', include('hotelmanagement_subsystem.urls', 'hotel_mg')),
    url(r'^support/', include('support_subsystem.urls', 'support')),
    url(r'^account/', include('user_subsystem.urls', 'user')),
)
