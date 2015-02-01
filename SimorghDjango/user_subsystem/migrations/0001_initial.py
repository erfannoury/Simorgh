# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.db import models, migrations
from django.conf import settings
import django.core.validators


class Migration(migrations.Migration):

    dependencies = [
        migrations.swappable_dependency(settings.AUTH_USER_MODEL),
    ]

    operations = [
        migrations.CreateModel(
            name='Account',
            fields=[
                ('id', models.AutoField(verbose_name='ID', serialize=False, auto_created=True, primary_key=True)),
                ('birthday', models.DateField(null=True, blank=True)),
                ('phone_number', models.CharField(max_length=12, validators=[django.core.validators.RegexValidator(regex=b'^\\d+$', message=b'\xd8\xa8\xd8\xa7\xdb\x8c\xd8\xaf \xd8\xb9\xd8\xaf\xd8\xaf \xd9\x88\xd8\xa7\xd8\xb1\xd8\xaf \xda\xa9\xd9\x86\xdb\x8c\xd8\xaf', code=b'nomatch')])),
                ('user', models.OneToOneField(to=settings.AUTH_USER_MODEL)),
            ],
            options={
            },
            bases=(models.Model,),
        ),
        migrations.CreateModel(
            name='RegistrationConfirmation',
            fields=[
                ('id', models.AutoField(verbose_name='ID', serialize=False, auto_created=True, primary_key=True)),
                ('confirmation_code', models.CharField(max_length=64)),
                ('expiration_time', models.DateTimeField()),
                ('account', models.OneToOneField(to='user_subsystem.Account')),
            ],
            options={
            },
            bases=(models.Model,),
        ),
        migrations.CreateModel(
            name='TravellerUser',
            fields=[
                ('id', models.AutoField(verbose_name='ID', serialize=False, auto_created=True, primary_key=True)),
                ('credit_amount', models.FloatField(default=0)),
                ('account', models.OneToOneField(to='user_subsystem.Account')),
            ],
            options={
            },
            bases=(models.Model,),
        ),
    ]
