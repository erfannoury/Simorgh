# -*- coding: utf-8 -*-
from __future__ import unicode_literals

from django.db import models, migrations


class Migration(migrations.Migration):

    dependencies = [
        ('customer_subsystem', '0001_initial'),
    ]

    operations = [
        migrations.RenameField(
            model_name='reservation',
            old_name='checkout_tiem',
            new_name='checkout_time',
        ),
        migrations.AddField(
            model_name='images',
            name='image',
            field=models.ImageField(null=True, upload_to=b''),
            preserve_default=True,
        ),
    ]
