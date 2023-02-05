﻿import React, { Component } from 'react';

export class Form extends Component {
    constructor(props) {
        super(props);
        this.state = {
            clientFirstName: '',
            clientLastName: '',
            clientStatus: 'Physical',
            clientCountry: '',
            clientPvmStatus: false,
            supplierFirstName: '',
            supplierLastName: '',
            supplierCountry: '',
            supplierPvmStatus: false,
            order: 0,
            pvmPercent: 0,
            countries: []
        };

        this.handleInputChange = this.handleInputChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
        this.populateCountryData();
    }

    componentDidMount() {
        this.populateCountryData();
    }

    handleInputChange(event) {
        const target = event.target;
        const value = target.type === 'checkbox' ? target.checked : target.value;
        const name = target.name;

        this.setState({
            [name]: value
        });
    }

    handleSubmit(event) {
        console.log(this.state);
        event.preventDefault();
    }

    async populateCountryData() {
        const response = await fetch('pvm/GetCountriesAsync');
        const data = await response.json();
        console.log(data);
        this.setState({ countries: data });
    }

    render() {
        return (
            <form onSubmit={this.handleSubmit}>
                <div className="container row">
                <div className="container col-sm">
                <div className="form-group">
                    <label>Kliento vardas </label>
                    <br />
                    <input
                        name="clientFirstName"
                        type="text"
                        value={this.state.clientFirstName}
                        onChange={this.handleInputChange} />
                </div>
                <br />
                <div className="form-group">
                    <label>Kliento pavarde</label>
                    <br />
                    <input
                        name="clientLastName"
                        type="text"
                        value={this.state.clientLastName}
                        onChange={this.handleInputChange} />
                </div>
                <br />
                <div className="form-group">
                    <label>Kliento statusas </label>
                    <br />
                    <select name="clientStatus" value={this.state.clientStatus} onChange={this.handleInputChange}>
                        <option value="Physical">Fizinis</option>
                        <option value="Juridical">Juridinis</option>
                    </select>
                </div>
                <br />
                <div className="form-group">
                    <label>Kliento salis </label>
                    <br />
                    <select name="clientCountry" value={this.state.clientCountry} onChange={this.handleInputChange}>
                        {this.state.countries.map(country =>
                            <option value={country}>{country}</option>
                        )}
                    </select>
                </div>
                <br />
                <div className="form-group">
                    <label>Klientas yra PVM moketojas ? </label>
                    <br />
                    <input
                        name="clientPvmStatus"
                        type="checkbox"
                        checked={this.state.clientPvmStatus}
                        onChange={this.handleInputChange} />
                </div>
                </div>
                <div className="container col-sm">
                <div className="form-group">
                    <label>Tiekejo vardas </label>
                    <br />
                    <input
                        name="supplierFirstName"
                        type="text"
                        value={this.state.supplierFirstName}
                        onChange={this.handleInputChange} />
                </div>
                <br />
                <div className="form-group">
                    <label>Tiekejo pavarde </label>
                    <br />
                    <input
                        name="supplierLastName"
                        type="text"
                        value={this.state.supplierLastName}
                        onChange={this.handleInputChange} />
                </div>
                <br />
                <div className="form-group">
                    <label>Tiekejo statusas </label>
                    <br />
                    <select name="supplierStatus" value={this.state.supplierStatus} onChange={this.handleInputChange}>
                        <option value="Physical">Fizinis</option>
                        <option value="Juridical">Juridinis</option>
                    </select>
                </div>
                <br />
                <div className="form-group">
                    <label>Tiekejo salis </label>
                    <br />
                    <select name="supplierCountry" value={this.state.supplierCountry} onChange={this.handleInputChange}>
                        {this.state.countries.map(country =>
                            <option value={country}>{country}</option>
                        )}
                    </select>
                </div>
                <br />
                <div className="form-group">
                    <label>Tiekejas yra PVM moketojas ?</label>
                    <br />
                    <input
                        name="supplierPvmStatus"
                        type="checkbox"
                        checked={this.state.supplierPvmStatus}
                        onChange={this.handleInputChange} />
                    </div>
                    </div>
                </div>
                <br />
                <div className="form-group">
                    <label>PVM procentas</label>
                    <br />
                    <input
                        name="pvmPercent"
                        type="number"
                        value={this.state.pvmPercent}
                        onChange={this.handleInputChange} />
                </div>
                <br />
                <div className="form-group">
                    <label>Uzsakymo suma </label>
                    <br />
                    <input
                        name="order"
                        type="number"
                        value={this.state.order}
                        onChange={this.handleInputChange} />
                </div>
                <br />
                <input type="submit" value="Submit" />
            </form>
        );
    }
}