from django.contrib.auth.models import User, Group
from agenda.models import Local, Compromisso, Convidado
from rest_framework import serializers


class UserSerializer(serializers.HyperlinkedModelSerializer):
    class Meta:
        model = User
        fields = ['url', 'username', 'email', 'groups']


class GroupSerializer(serializers.HyperlinkedModelSerializer):
    class Meta:
        model = Group
        fields = ['url', 'name']


class LocalSerializer(serializers.HyperlinkedModelSerializer):
    class Meta:
        model = Local
        fields = ['url', 'nome', 'rua', 'numero']


class CompromissoSerializer(serializers.HyperlinkedModelSerializer):
    class Meta:
        model = Compromisso
        fields = ['url', 'descricao', 'data_inicio', 'data_fim', 'local']


class ConvidadoSerializer(serializers.HyperlinkedModelSerializer):
    class Meta:
        model = Convidado
        fields = ['url', 'nome', 'email']
