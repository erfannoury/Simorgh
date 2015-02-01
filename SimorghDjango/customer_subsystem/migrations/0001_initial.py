# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.db import models, migrations


class Migration(migrations.Migration):

    dependencies = [
        ('user_subsystem', '0001_initial'),
    ]

    operations = [
        migrations.CreateModel(
            name='City',
            fields=[
                ('id', models.AutoField(verbose_name='ID', serialize=False, auto_created=True, primary_key=True)),
                ('name', models.CharField(max_length=100)),
            ],
            options={
            },
            bases=(models.Model,),
        ),
        migrations.CreateModel(
            name='Hotel',
            fields=[
                ('id', models.AutoField(verbose_name='ID', serialize=False, auto_created=True, primary_key=True)),
                ('name', models.CharField(max_length=100)),
                ('address', models.TextField()),
                ('longitude', models.FloatField()),
                ('latitude', models.FloatField()),
                ('description', models.TextField(null=True, blank=True)),
                ('star', models.SmallIntegerField(max_length=5)),
                ('city', models.ForeignKey(to='customer_subsystem.City')),
            ],
            options={
            },
            bases=(models.Model,),
        ),
        migrations.CreateModel(
            name='Images',
            fields=[
                ('id', models.AutoField(verbose_name='ID', serialize=False, auto_created=True, primary_key=True)),
                ('file_path', models.CharField(max_length=100)),
                ('hotel', models.ForeignKey(blank=True, to='customer_subsystem.Hotel', null=True)),
            ],
            options={
            },
            bases=(models.Model,),
        ),
        migrations.CreateModel(
            name='Rating',
            fields=[
                ('id', models.AutoField(verbose_name='ID', serialize=False, auto_created=True, primary_key=True)),
                ('staff_behavior', models.SmallIntegerField(max_length=10)),
                ('room_clearliness', models.SmallIntegerField(max_length=10)),
                ('outdoor_clearliness', models.SmallIntegerField(max_length=10)),
                ('prestige', models.SmallIntegerField(max_length=10)),
                ('food_quality', models.SmallIntegerField(max_length=10)),
                ('environment', models.SmallIntegerField(max_length=10)),
                ('price_quality', models.SmallIntegerField(max_length=10)),
                ('overall', models.SmallIntegerField(max_length=10)),
                ('hotel_review', models.TextField()),
                ('hotel', models.ForeignKey(to='customer_subsystem.Hotel')),
                ('traveller', models.OneToOneField(to='user_subsystem.Account')),
            ],
            options={
            },
            bases=(models.Model,),
        ),
        migrations.CreateModel(
            name='Reservation',
            fields=[
                ('id', models.AutoField(verbose_name='ID', serialize=False, auto_created=True, primary_key=True)),
                ('reservation_time', models.DateTimeField()),
                ('checkin_time', models.DateTimeField()),
                ('checkout_tiem', models.DateTimeField()),
                ('quantity', models.IntegerField()),
            ],
            options={
            },
            bases=(models.Model,),
        ),
        migrations.CreateModel(
            name='RoomReview',
            fields=[
                ('id', models.AutoField(verbose_name='ID', serialize=False, auto_created=True, primary_key=True)),
                ('review_date', models.DateTimeField()),
                ('review', models.TextField()),
                ('rate_up', models.SmallIntegerField(default=0)),
                ('rate_down', models.SmallIntegerField(default=0)),
                ('is_confirmed', models.BooleanField(default=False)),
            ],
            options={
            },
            bases=(models.Model,),
        ),
        migrations.CreateModel(
            name='RoomType',
            fields=[
                ('id', models.AutoField(verbose_name='ID', serialize=False, auto_created=True, primary_key=True)),
                ('title', models.CharField(max_length=100)),
                ('description', models.TextField()),
                ('capacity', models.IntegerField()),
                ('price', models.FloatField()),
                ('hotel', models.ForeignKey(to='customer_subsystem.Hotel')),
            ],
            options={
            },
            bases=(models.Model,),
        ),
        migrations.AddField(
            model_name='roomreview',
            name='roomType',
            field=models.ForeignKey(to='customer_subsystem.RoomType'),
            preserve_default=True,
        ),
        migrations.AddField(
            model_name='reservation',
            name='roomType',
            field=models.ForeignKey(to='customer_subsystem.RoomType'),
            preserve_default=True,
        ),
        migrations.AddField(
            model_name='reservation',
            name='traveller',
            field=models.ForeignKey(to='user_subsystem.Account'),
            preserve_default=True,
        ),
        migrations.AddField(
            model_name='images',
            name='room_type',
            field=models.ForeignKey(blank=True, to='customer_subsystem.RoomType', null=True),
            preserve_default=True,
        ),
    ]
