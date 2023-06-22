from django.contrib import admin
from agenda.models import Compromisso, Local, Convidado
# Register your models here.


class ConvidadosInline(admin.TabularInline):
    model = Compromisso.convidados.through


class ConvidadoAdmin(admin.ModelAdmin):
    inlines = [
        ConvidadosInline,
    ]


class CompromissoAdmin(admin.ModelAdmin):
    inlines = [
        ConvidadosInline,
    ]
    exclude = ['convidados']


admin.site.register(Compromisso, CompromissoAdmin)
admin.site.register(Local)
admin.site.register(Convidado, ConvidadoAdmin)