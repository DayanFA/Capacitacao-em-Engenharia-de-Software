from django.http import HttpResponse
from .models import Local
from django.template import loader


def lista_locais(request):
    locais = Local.objects.all()
    template = loader.get_template('locais.html')
    context = {
        'locais': locais,
    }

    return HttpResponse(template.render(context, request))