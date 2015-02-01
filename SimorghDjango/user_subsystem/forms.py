from django.forms import  ModelForm
from django.contrib.auth.models import User
from user_subsystem.models import TravellerUser, Account

class UserForm(ModelForm):
    def __init__(self, *args, **kwargs):
        super(UserForm, self).__init__(*args, **kwargs)

        for key in self.fields:
            self.fields[key].required = True
    class Meta:
        model = User
        fields = ['username', 'password', 'first_name', 'last_name', 'email']

class AccountForm(ModelForm):
    class Meta:
        model = Account
        exclude = ['user', 'type']

class UserEditForm(ModelForm):
    def __init__(self, *args, **kwargs):
        super(UserEditForm, self).__init__(*args, **kwargs)

        for key in self.fields:
            self.fields[key].required = True
    class Meta:
        model = User
        fields = ['first_name', 'last_name']

class AccountEditForm(ModelForm):
    def __init__(self, *args, **kwargs):
        super(AccountEditForm, self).__init__(*args, **kwargs)

        for key in self.fields:
            self.fields[key].required = True
    class Meta:
        model = Account
        exclude = ['user']
