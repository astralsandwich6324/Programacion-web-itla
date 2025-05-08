//class EstadoCompartido {
//    constructor() {
//        this.link = "#";
//        this.botonDinamico = "registrovivencias";
//        this.valueBotonDinamico = "Registrate";
//        this.claseBotonDinamico = "btn-warning";
//    }

//    cambiarEstado(nuevosValores) {
//        if (nuevosValores.link) this.link = nuevosValores.link;
//        if (nuevosValores.botonDinamico) this.botonDinamico = nuevosValores.botonDinamico;
//        if (nuevosValores.valueBotonDinamico) this.valueBotonDinamico = nuevosValores.valueBotonDinamico;
//        if (nuevosValores.claseBotonDinamico) this.claseBotonDinamico = nuevosValores.claseBotonDinamico;

//        // Reflejar los cambios en el DOM
//        document.querySelector("#linkDinamico").href = this.link;
//        document.querySelector("#botonDinamico").href = this.botonDinamico;
//        document.querySelector("#botonDinamico").textContent = this.valueBotonDinamico;
//        document.querySelector("#botonDinamico").className = `link btn ${this.claseBotonDinamico}`;
//    }
//}

//// Instanciar la clase globalmente para su uso
//const estadoCompartido = new EstadoCompartido();
