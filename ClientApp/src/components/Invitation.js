import React, {useState} from 'react';
import { Button, Form, FormGroup, Label, Input } from 'reactstrap';

const Invitation = (props) => {

    const [email, setEmail] = useState("");

    const onSubmit = (e) => {
        e.preventDefault()
        if(email){
            
            //post
        }
    }
    return (
        <Form inline onSubmit={e => onSubmit(e)}>
            <Label>Invite an employee </Label>
            <FormGroup className="mb-2 mr-sm-2 mb-sm-0">
                <Input type="email" name="email" id="Email" placeholder="something@idk.cool" onChange={e => setEmail(e.target.value)}/>
            </FormGroup>
            <Button>Submit</Button>
        </Form>
    );
}

export default Invitation;
