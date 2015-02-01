# -*- coding: utf-8 -*-
from django.db import models
from django.contrib.auth.models import User
from django.core.validators import RegexValidator
from django import forms

class Account(models.Model):
    ACCOUNT_TYPE = (
            ("a", "A"),
            ("b", "B"),
            )
    user = models.OneToOneField(User)
    birthday = models.DateField(null=True, blank=True)
    phone_number = models.CharField(max_length=12,validators=[RegexValidator(regex='^\d+$', message='باید عدد وارد کنید', code='nomatch')])
    type = forms.MultipleChoiceField(widget=forms.CheckboxSelectMultiple,
                                         choices=ACCOUNT_TYPE)
    def __str__(self):
        return str(self.id)

class TravellerUser(models.Model):
    account = models.OneToOneField(Account)
    credit_amount = models.FloatField(default=0)
    def __str__(self):
        return str(self.id)

class RegistrationConfirmation(models.Model):
    confirmation_code = models.CharField(max_length=64)
    account = models.OneToOneField('account')
    expiration_time = models.DateTimeField()
    def __str__(self):
        return str(self.id)
