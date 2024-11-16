window.initializeLeafletMap = function (detentions) {
    var map = L.map('map').setView([18.83927601491119, -70.60756718938437], 8);

    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        attribution: '© OpenStreetMap contributors'
    }).addTo(map);

    detentions.forEach(function (detencion) {
        
        var formattedDetentionDate = new Date(detencion.fechaDetencion).toLocaleDateString();

        
        L.marker([detencion.latitud, detencion.longitud]).addTo(map)
            .bindPopup(`<b>${detencion.name} ${detencion.apellido}</b><br />Detención: ${formattedDetentionDate}`);
    });
};
