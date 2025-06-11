const Usuario = () => {
    return(
        <>
        <div className="container">
            <h1>Usuarios</h1>
        </div>
        <div className="container">
            <div className="card">
                <div className="card-header">Busqueda</div>
                <div className="card-body">
                    <div className="row">
                        <div className="col-12">
                            <div className="mb-3">
                                <label>Busqueda de Usuarios</label>
                                <input type="text" className="form-control" placeholder="Introduce el nombre o el correo" />
                            </div>
                        </div>
                        <div className="col-12">
                            <button className="btn btn-primary">Buscar</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        </>
    )
}
export default Usuario;