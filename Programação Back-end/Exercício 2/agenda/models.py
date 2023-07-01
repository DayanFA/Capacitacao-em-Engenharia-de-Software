from django.contrib.auth.models import User
from django.db import models

# Create your models here.
class Local(models.Model):
    foto = models.ImageField(upload_to='fr_locais', null=True, blank=True)
    nome = models.CharField(max_length=80)
    rua = models.CharField(max_length=120)
    numero = models.IntegerField()

    def __str__(self):
        return f'{self.nome} na rua {self.rua}'
    class Meta:
        verbose_name_plural = "Locais"

class Convidado(models.Model):
    nome = models.CharField(max_length=80)
    email = models.EmailField(null=True, blank=True)
    usuario= models.OneToOneField(
        User, on_delete=models.CASCADE, null=True, blank=True
    )
    def __str__(self):
        return f'{self.nome} - {self.email}'


class Compromisso(models.Model):
    descricao = models.CharField(max_length=255)
    data_inicio = models.DateTimeField(null=True)
    data_fim = models.DateTimeField(null=True)
    local = models.ForeignKey(Local, on_delete=models.CASCADE)
    registro = models.FileField(upload_to='arquivos', null=True, blank=True)
    convidados = models.ManyToManyField(Convidado)

    def __str__(self):
        return f'{self.descricao} começa {self.data_inicio} ate {self.data_fim}'


