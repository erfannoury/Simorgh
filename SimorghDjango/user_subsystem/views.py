# -*- coding: utf-8 -*-
from django.shortcuts import render
from django.shortcuts import render, redirect
from django.core.urlresolvers import reverse
from django.contrib.auth import authenticate, login, logout
from django.forms import  ModelForm
from  django.contrib.auth.models import User
from user_subsystem.models import Account, TravellerUser, RegistrationConfirmation
from django.db.models import Q
from django.contrib.auth.decorators import user_passes_test, login_required
from user_subsystem.forms import AccountEditForm, AccountForm, UserForm, UserEditForm

def is_traveller(user):
    try:
        if user.account.type=="t":
            return True
    except Exception as e:
        return False
    return False

def is_hotelowner(user):
    try:
        if user.account.type=="h" :
            return True
    except Exception as e:
        return False
    return False


def logout_user(request):
    logout(request)
    return redirect(reverse('customer:index'))

def register_user(request):
    if request.method == 'POST':
        user_form = UserForm(request.POST, prefix='user')
        account_form = AccountForm(request.POST, prefix='account')
        if user_form.is_valid() and account_form.is_valid():
            user = user_form.save(commit=False)
            user.set_password(user.password)
            user.save()
            account = account_form.save(commit=False)
            account.user = user
            account.save()
            traveller = TravellerUser()
            traveller.account = account
            account.save()
            return redirect(reverse('customer:index'))
    else:
        user_form = UserForm(prefix='user')
        account_form = AccountForm(prefix='account')

    return render(request, 'user_subsystem/register.html', {'user_form' : user_form, 'account_form' : account_form})

